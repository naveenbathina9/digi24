namespace Digi24.Repository.Infrastructure
{
    using System;
    using System.Configuration;
    using System.Data;
    using System.Data.Common;

    public class DbStore : IDbStore
    {

        private DbProviderFactory dbProviderFactory;
        private ConnectionStringSettings connectionStringSettings;
        private IDbConnection dbConnection;

        public DbStore(string connectionStringName)
        {
            ConnectionString = ConfigurationManager.ConnectionStrings[connectionStringName];
            //OpenConnection();
        }

        public int ExecuteNonQuery(string query, DbParameters parms)
        {
            OpenConnection();
            var parameters = this.BuildParameters(parms);
            return GetCommandForCurrentConnection(query, parameters).ExecuteNonQuery();
        }

        public object ExecuteScalarQuery(string query, DbParameters parms)
        {
            OpenConnection();
            var parameters = this.BuildParameters(parms);
            return GetCommandForCurrentConnection(query, parameters).ExecuteScalar();
        }

        public IDataReader ExecuteQuery(string query, DbParameters parms)
        {
            OpenConnection();
            var parameters = this.BuildParameters(parms);
            return GetCommandForCurrentConnection(query, parameters).ExecuteReader();
        }

        public object ExecuteStoredProcedure(string name, DbParameters parms)
        {
            OpenConnection();
            var parameters = this.BuildParameters(parms);
            return GetCommandForCurrentConnection(name, parameters, CommandType.StoredProcedure).ExecuteScalar();
        }

        public int ExecuteNonQueryStoredProcedure(string name, DbParameters parms)
        {
            OpenConnection();
            var parameters = this.BuildParameters(parms);
            return GetCommandForCurrentConnection(name, parameters, CommandType.StoredProcedure).ExecuteNonQuery();
        }

        public DataSet ExecuteStoredProcWithDataAdapter(string procedureName, DbParameters parameter)
        {
            OpenConnection();
            var parameters = this.BuildParameters(parameter);

            IDbCommand cmd = GetCommandForCurrentConnection(procedureName, parameters, CommandType.StoredProcedure);
            IDbDataAdapter dbAdapter = dbProviderFactory.CreateDataAdapter();
            dbAdapter.SelectCommand = cmd;
            DataSet ds = new DataSet();
            dbAdapter.Fill(ds);
            return ds;
        }

        public void Dispose()
        {
            CloseConnection();
        }

        private ConnectionStringSettings ConnectionString
        {
            get
            {
                if (connectionStringSettings == null)
                {
                    throw new Exception("Connection string not set.");
                }
                else
                {
                    return connectionStringSettings;
                }
            }
            set
            {
                connectionStringSettings = value;
            }
        }

        private IDataParameter GetParameter(string parameterName, object parameterValue, DbType dbType)
        {
            IDataParameter dbParameter = dbProviderFactory.CreateParameter();
            dbParameter.ParameterName = parameterName;
            dbParameter.Value = parameterValue;
            return dbParameter;
        }

        private void OpenConnection()
        {
            if (dbConnection == null || dbConnection.State != ConnectionState.Open)
            {
                dbProviderFactory = DbProviderFactories.GetFactory(connectionStringSettings.ProviderName);
                dbConnection = dbProviderFactory.CreateConnection();
                dbConnection.ConnectionString = connectionStringSettings.ConnectionString;
                dbConnection.Open();
            }
        }

        private void CloseConnection()
        {
            if (dbConnection == null)
                return;

            if (dbConnection.State == ConnectionState.Open)
            {
                dbConnection.Close();
            }
            dbConnection.Dispose();
            dbConnection = null;
        }

        private IDbCommand GetCommandForCurrentConnection(string query, IDataParameter[] parameters, CommandType commandType = CommandType.Text)
        {
            IDbCommand dbCommand = dbProviderFactory.CreateCommand();
            dbCommand.Connection = dbConnection;
            dbCommand.CommandText = query;
            dbCommand.CommandType = commandType;
            if (parameters != null)
            {
                foreach (IDataParameter dataParameter in parameters)
                {
                    dbCommand.Parameters.Add(dataParameter);
                }
            }

            return dbCommand;
        }

        private IDataParameter[] BuildParameters(DbParameters parms)
        {
            IDataParameter[] parameters = (parms == null) ? null : new IDataParameter[parms.Count];

            if (parameters != null)
            {
                for (int i = 0; i < parms.Count; i++)
                {
                    var name = parms[i].Item1;
                    var value = parms[i].Item2;
                    var type = parms[i].Item3;
                    parameters[i] = this.GetParameter(name, value, type);
                }
            }
            return parameters;
        }
    }
}

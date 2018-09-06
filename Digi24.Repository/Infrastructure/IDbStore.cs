
namespace Digi24.Repository.Infrastructure
{
    using System;
    using System.Data;

    public interface IDbStore : IDisposable
    {
        int ExecuteNonQuery(string query, DbParameters parms);
        int ExecuteNonQueryStoredProcedure(string name, DbParameters parms);
        IDataReader ExecuteQuery(string query, DbParameters parms);
        object ExecuteScalarQuery(string query, DbParameters parms);
        object ExecuteStoredProcedure(string name, DbParameters parms);
        DataSet ExecuteStoredProcWithDataAdapter(string procedureName, DbParameters parameter);
    }
}

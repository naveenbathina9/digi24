namespace Digi24.Repository.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Data;

    public class DbParameters : List<Tuple<string, object, DbType>>
    {
        public void Add(string pName, object pValue, DbType dbType = DbType.AnsiString)
        {
            Add(new Tuple<string, object, DbType>(pName, pValue, dbType));
        }

        public void Remove(string pName, object pValue, DbType dbType = DbType.AnsiString)
        {
            Remove(new Tuple<string, object, DbType>(pName, pValue, dbType));
        }
    }
}

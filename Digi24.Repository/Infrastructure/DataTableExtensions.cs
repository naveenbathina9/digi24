using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.Repository.Infrastructure
{
    using System;
    using System.Data;
    using System.Collections.Generic;

    public static class DataTableExtensions
    {
        public static List<T> ToList<T>(this DataTable dt, T entity) where T : class
        {
            List<T> entities = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    var name = dt.Columns[i];
                    var val = row[name];

                    if (!(val is DBNull))
                    {
                        entity.GetType().GetProperty(name.ColumnName).SetValue(entity, val);
                    }
                }
                entities.Add(entity);
                entity = (T)Activator.CreateInstance(entity.GetType());
            }
            return entities;
        }

        public static T ToObject<T>(this DataTable dt, T entity) where T : class
        {
            if (dt.Rows.Count == 0)
            {
                entity = null;
            }
            else
            {
                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        var name = dt.Columns[i];
                        var val = row[name];

                        if (!(val is DBNull))
                        {
                            entity.GetType().GetProperty(name.ColumnName).SetValue(entity, val);
                        }
                    }
                }
            }

            return entity;
        }
    }
}

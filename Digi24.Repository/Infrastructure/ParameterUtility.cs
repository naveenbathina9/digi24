using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.Repository.Infrastructure
{
    using System.Reflection;

    public class ParameterUtility
    {
        public static DbParameters CreateParameterFromClassObject<T>(T classObject)
        {
            PropertyInfo[] properties = classObject.GetType().GetProperties();
            var parameters = new DbParameters();
            foreach (PropertyInfo property in properties)
            {
                if (property.GetValue(classObject) != null)
                {
                    parameters.Add(property.Name, property.GetValue(classObject));
                }
            }
            return parameters;
        }
    }
}

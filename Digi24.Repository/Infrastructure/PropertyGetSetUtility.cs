using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digi24.Repository.Infrastructure
{
    public class PropertyGetSetUtility
    {
        public static object GetPropertyValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src, null);
        }

        public static bool ValidatePropertyValue(object src, string propName)
        {
            var type = src.GetType().GetProperty(propName).PropertyType.Name;
            var value = src.GetType().GetProperty(propName).GetValue(src, null);
            bool isValid = false;
            switch (type)
            {
                case "Int32":
                    isValid = value.ToString() == "0" ? true : false;
                    break;
                case "String":
                    isValid = Convert.ToString(value) == "" ? true : false;
                    break;
                case "DateTime":
                    isValid = value.ToString() == "1/1/0001 12:00:00 AM" ? true : false;
                    break;
                case "Boolean":
                    isValid = (Boolean)value == false ? true : false;
                    break;
                case "Nullable`1":
                    isValid = value == null ? true : false;
                    break;
                case "Guid":
                    isValid = (Guid)value == new Guid("00000000-0000-0000-0000-000000000000") ? true : false;
                    break;
            }
            return isValid;
        }

        public static void SetPropertyValue(object src, string propName)
        {
            var type = src.GetType().GetProperty(propName).PropertyType.Name;
            object setValue = null;
            switch (type)
            {
                case "Int32":
                    setValue = 0;
                    break;
                case "String":
                    setValue = "";
                    break;
                case "DateTime":
                    setValue = "1/1/0001 12:00:00 AM";
                    break;
                case "Nullable`1":
                    setValue = null;
                    break;
                case "Guid":
                    setValue = new Guid("00000000-0000-0000-0000-000000000000");
                    break;
            }
            src.GetType().GetProperty(propName).SetValue(src, setValue, null);
        }
    }
}

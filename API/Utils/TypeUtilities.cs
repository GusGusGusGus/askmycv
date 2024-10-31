using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Utils
{
    public static class TypeUtilities
    {
        public static bool IsDefaultForType(object value)
        {
            if (value.GetType() == typeof(string) && value == "")
            {
                return true;
            }
            if (value.GetType() == typeof(int) && (int)value == 0)
            {
                return true;
            }
            if (value.GetType() == typeof(bool) && (bool)value == false)
            {
                return true;
            }


            // Check if the value is equal to the default value
            return object.Equals(value, GetDefaultForType(value.GetType()));
        }

        public static object GetDefaultForType(Type type)
        {
            if (type == typeof(string))
            {
                return ""; // Default value for string (empty string)
            }
            else
            {
                return Activator.CreateInstance(type); // Default value for value types
            }
        }
    }
}
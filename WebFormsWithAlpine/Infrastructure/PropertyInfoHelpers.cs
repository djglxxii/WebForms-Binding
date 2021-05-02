using System;
using System.Linq;
using System.Reflection;

namespace WebFormsWithAlpine.Infrastructure
{
    internal static class PropertyInfoHelpers
    {
        public static bool IsJsonSerialized(this PropertyInfo pi)
        {
            var attrs = pi.GetCustomAttributes<JsonDataAttribute>();
            return attrs.Any();
        }
    }
}
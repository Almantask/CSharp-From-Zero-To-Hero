using System;
using System.Reflection;

namespace BootCamp.Chapter
{
    public static class AttributesGetter
    {
        public static T GetClassAttribute<T>(Type type)
        where T : Attribute
        {
            return Attribute.GetCustomAttribute(type, typeof(T)) as T;
        }

        public static T GetPropertyAttribute<T>(PropertyInfo prop)
            where T : Attribute
        {
            return prop.GetCustomAttribute(typeof(T)) as T;
        }
    }
}
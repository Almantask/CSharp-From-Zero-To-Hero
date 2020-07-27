using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class AttributesGetter
    {
        public static T GetClassAttribute<T>(Type type) where T : Attribute
        {
            return Attribute.GetCustomAttribute(type, typeof(T)) as T;
        }
    }
}

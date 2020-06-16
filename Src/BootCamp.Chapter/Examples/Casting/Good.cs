using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples.Casting
{
    public class Cache
    {
        private readonly Dictionary<Type, object> _cachedObjects = new Dictionary<Type, object>();

        public void Save<T>(T obj)
        {
            _cachedObjects.Add(typeof(T), obj);
        }

        public T Get<T>() where T : class
        {
            var type = typeof(T);
            if (_cachedObjects.ContainsKey(type))
            {
                return _cachedObjects[type] as T;
            }

            return null;
        }
    }
}

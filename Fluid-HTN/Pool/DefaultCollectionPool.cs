
using System.Collections.Generic;

namespace FluidHTN.Factory
{
    public sealed class DefaultCollectionPool : ICollectionPool
    {
        public T[] GetArray<T>(int length)
        {
            return new T[length];
        }

        public List<T> GetList<T>()
        {
            return new List<T>();
        }

        public Queue<T> GetQueue<T>()
        {
            return new Queue<T>();
        }

        public bool ReturnArray<T>(ref T[] array)
        {
            array = null;
            return array == null;
        }

        public bool ReturnList<T>(ref List<T> list)
        {
            list = null;
            return list == null;
        }

        public bool ReturnQueue<T>(ref Queue<T> queue)
        {
            queue = null;
            return queue == null;
        }

        public T Create<T>() where T : new()
        {
            return new T();
        }

        public bool Free<T>(ref T obj)
        {
            obj = default(T);
            return obj == null;
        }
    }
}

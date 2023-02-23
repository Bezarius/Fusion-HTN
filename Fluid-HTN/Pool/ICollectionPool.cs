
using System.Collections.Generic;

namespace FluidHTN.Factory
{
    public interface ICollectionPool
    {
        T[] GetArray<T>(int length);
        bool ReturnArray<T>(ref T[] array);

        Queue<T> GetQueue<T>();
        bool ReturnQueue<T>(ref Queue<T> queue);

        List<T> GetList<T>();
        bool ReturnList<T>(ref List<T> list);

        T Create<T>() where T : new();
        bool Free<T>(ref T obj);
    }
}

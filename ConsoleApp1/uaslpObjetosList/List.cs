using uaslp.objetos.list;

namespace uaslp.objetos.list
{
    public interface List<T>
    {
        void AddAtFront(T data);
        void AddAtTail(T data);
        void Remove(int index);
        void SetAt(int index, T data);
        T GetAt(int index);
        void RemoveAllWithValue(T data);
        int GetSize();
        Iterator<T> GetIterator();
    }
}

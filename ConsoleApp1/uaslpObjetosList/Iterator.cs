using uaslp.objetos.list;

namespace uaslp.objetos.list
{
    public interface Iterator<T>
    {
        bool HasNext();
        T Next();
    }
}


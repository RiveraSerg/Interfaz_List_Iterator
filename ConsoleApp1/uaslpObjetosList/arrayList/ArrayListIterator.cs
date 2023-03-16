using uaslp.objetos.list;
using System;

namespace uaslp.objetos.list.arraylist
{
    public class ArrayListIterator<H> : Iterator<H>
    {
        private int i;
        private readonly Object[] currentArray;

        public ArrayListIterator(Object[] array)
        {
            currentArray = array;
        }

        public bool HasNext()
        {
            return i < currentArray.Length && currentArray[i] != null;
        }

        public H Next()
        {
            Object data = currentArray[i];
            i++;
            return (H)data;
        }
    }
}

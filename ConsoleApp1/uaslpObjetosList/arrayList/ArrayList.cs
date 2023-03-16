using uaslp.objetos.list;

namespace uaslp.objetos.list.arraylist
{
    public class ArrayList<T> : List<T>
    {
        private const int INITIAL_SIZE = 2;
        private object[] array;
        private int size;

        public ArrayList()
        {
            array = new object[INITIAL_SIZE];
        }

        public void AddAtTail(T data)
        {
            if (size == array.Length)
            {
                IncreaseSize();
            }
            array[size] = data;
            size++;
        }

        public void AddAtFront(T data)
        {
            if (size == array.Length)
            {
                IncreaseSize();
            }
            object[] newArray = new object[array.Length];
            newArray[0] = data;
            System.Array.Copy(array, 0, newArray, 1, array.Length - 1);
            array = newArray;
            size++;
        }

        public void Remove(int index)
        {
            for (int i = index; i + 1 < array.Length; i++)
            {
                array[i] = array[i + 1];
            }
            array[size - 1] = null;
            size--;
        }

        public void RemoveAll()
        {
            object[] newArray;
            newArray = new object[INITIAL_SIZE];
            array = newArray;
            size = 0;
        }

        public void SetAt(int index, T data)
        {
            array[index] = data;
        }

        public T GetAt(int index)
        {
            return (T)array[index];
        }

        public void RemoveAllWithValue(T data)
        {
            if (data.Equals(array[0]))
            {
                Remove(0);
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (data.Equals(array[i]))
                {
                    Remove(i);
                }
            }
        }

        public int GetSize()
        {
            return size;
        }

        private void IncreaseSize()
        {
            object[] newArray = new object[array.Length * 2];

            System.Array.Copy(array, 0, newArray, 0, array.Length);
            array = newArray;
        }

        public Iterator<T> GetIterator()
        {
            return new ArrayListIterator<T>(array);
        }
    }
}

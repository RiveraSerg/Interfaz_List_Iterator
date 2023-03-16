using uaslp.objetos.list;
using System;

namespace uaslp.objetos.list.linkedlist
{
    public class LinkedList<T> : List<T>
    {
        private Node<T> tail;
        private Node<T> head;
        private int size;

        public LinkedList()
        {
            tail = null;
            head = null;
            size = 0;
        }

        public void AddAtFront(T data)
        {
            if (head != null)
            {
                head = new Node<T>(data, head, null);
                head.next.previous = head;
            }
            else
            {
                head = tail = new Node<T>(data, null, null);
            }
            size++;
        }

        public void AddAtTail(T data)
        {
            if (head != null)
            {
                tail = new Node<T>(data, null, tail);
                tail.previous.next = tail;
            }
            else
            {
                head = tail = new Node<T>(data, null, null);
            }
            size++;
        }

        public void Remove(int index)
        {
            Node<T> aux = head;
            for (int cont = 1; cont < index; cont++)
            {
                aux = aux.next;
            }
            if (aux == head)
            {
                head = head.next;
                head.previous = null;
            }
            else if (aux == tail)
            {
                tail = aux.previous;
                tail.next = null;
            }
            else
            {
                aux.previous.next = aux.next;
                aux.next.previous = aux.previous;
            }
            size--;
        }

        public void RemoveAll()
        {
            head = null;
            tail = null;
        }

        public void SetAt(int index, T data)
        {
            Node<T> aux = head;
            for (int cont = 1; cont < index; cont++)
            {
                aux = aux.next;
            }
            aux.data = data;
        }

        public T GetAt(int index)
        {
            Node<T> aux = head;
            for (int cont = 1; cont < index; cont++)
            {
                aux = aux.next;
            }
            return aux.data;
        }

        public void RemoveAllWithValue(T data)
        {
            Node<T> aux = head;
            int cont = 0;
            while (aux != null)
            {
                if (data.Equals(aux.data))
                {
                    Remove(cont);
                }
                cont++;
                aux = aux.next;
            }
        }

        public int GetSize()
        {
            return size;
        }

        public Iterator<T> GetIterator()
        {
            return new LinkedListIterator<T>(head);
        }
    }
}

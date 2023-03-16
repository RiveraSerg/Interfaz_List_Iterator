using uaslp.objetos.list;
using System;

namespace uaslp.objetos.list.linkedlist
{
    public class LinkedListIterator<K> : Iterator<K>
    {
        private Node<K> currentNode;

        public LinkedListIterator(Node<K> head)
        {
            currentNode = head;
        }

        public bool HasNext()
        {
            return currentNode != null;
        }

        public K Next()
        {
            K data = currentNode.data;
            currentNode = currentNode.next;
            return data;
        }
    }
}



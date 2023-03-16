using uaslp.objetos.list;
using System;

namespace uaslp.objetos.list.linkedlist
{
    public class Node<O>
    {
        public O data;
        public Node<O> next;
        public Node<O> previous;

        public Node(O data, Node<O> h, Node<O> t)
        {
            this.data = data;
            next = h;
            previous = t;
        }
    }
}


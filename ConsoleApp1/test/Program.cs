using System;

using List = uaslp.objetos.list.List<string>;
using ArrayList = uaslp.objetos.list.arraylist.ArrayList<string>;
using LinkedList = uaslp.objetos.list.linkedlist.LinkedList<string>;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int tam;
            string data;

            List list2 = new ArrayList();
            List list1 = new LinkedList();

            list2.AddAtTail("A");
            list2.AddAtTail("B");
            list2.AddAtTail("C");
            list2.AddAtFront("D");
            list2.AddAtFront("D");
            list2.AddAtFront("D");

            list1.AddAtTail("1");
            list1.AddAtTail("2");
            list1.AddAtTail("3");
            list1.AddAtFront("8");
            list1.AddAtFront("7");
            list1.AddAtFront("7");

            Console.Write("Lista 2: ");
            PrintList(list2);
            tam = list2.GetSize();
            Console.WriteLine("tamaño: " + tam);

            Console.Write("Lista 1: ");
            PrintList(list1);
            tam = list1.GetSize();
            Console.WriteLine("tamaño: " + tam);

            list1.Remove(4);
            list2.Remove(4);
            Console.WriteLine("Remover en la posición No. 4: ");

            Console.Write("Lista 2: ");
            PrintList(list2);
            Console.WriteLine("tamaño: " + tam);

            Console.Write("Lista 1: ");
            PrintList(list1);
            tam = list1.GetSize();
            Console.WriteLine("tamaño: " + tam);

            list1.RemoveAllWithValue("7");
            list2.RemoveAllWithValue("D");
            Console.WriteLine("Remover Todos con Valor 7 y D");

            Console.Write("Lista 2: ");
            PrintList(list2);
            tam = list2.GetSize();
            Console.WriteLine("tamaño: " + tam);

            Console.Write("Lista 1: ");
            PrintList(list1);
            tam = list1.GetSize();
            Console.WriteLine("tamaño: " + tam);

            list1.SetAt(1, "2");
            list2.SetAt(0, "H");
            Console.WriteLine("Colocar en la primera posición 2 y H");

            Console.Write("Lista 2: ");
            PrintList(list2);
            Console.WriteLine("tamaño: " + tam);

            Console.Write("Lista 1: ");
            PrintList(list1);
            Console.WriteLine("tamaño: " + tam);

            Console.WriteLine("Obtener la ultima posicion");
            data = list2.GetAt(2);
            Console.WriteLine("Lista 2: " + data);
            data = list1.GetAt(3);
            Console.WriteLine("Lista 1: " + data);
        }

        public static void PrintList(List list)
        {
            var iterator = list.GetIterator();
            Console.Write("Lista 1: ");
            while (iterator.HasNext())
            {
                var dato = iterator.Next();
                Console.Write("[" + dato + "]<----->");
            }
        }
    }
}

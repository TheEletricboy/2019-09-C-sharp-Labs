using System;
using System.Collections.Generic;
using System.Collections;

namespace lab_22_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //dictionary
            //key is index 0,1,2,3 
            //value is string saved
            //pairs 0, "hi"    1,"there"
            var dictionary = new Dictionary<int, string>();
            dictionary.Add(0, "hello");
            dictionary.Add(1, "there");
            //dictionary.TryAdd(1, "there");
            //dictionary.TryAdd(2, "there");


            //get values

            foreach (KeyValuePair<int,string> item in dictionary)
            {
                Console.WriteLine($"{item.Key, -10}{item.Value}");  //the -10 is -10 lines in the command line
            }

            //queue
            Queue myq = new Queue();


            myq.Enqueue("string 1");
            myq.Enqueue("string 2");
            myq.Enqueue("string 3");
            myq.Enqueue("string 4");

            foreach (var item in myq)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();






            //stack

            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(10);
            stack.Push(100);
            foreach (var item in stack) { Console.WriteLine(item); }
            Console.ReadLine();



            //List



            //ArrayList

            var arraylist = new ArrayList();
            arraylist.Add(1);
            arraylist.Add("hi");
            foreach (var item in arraylist) { Console.WriteLine(item.ToString()); }
            Console.ReadLine();


            //LinkedList

            LinkedList<string> linkedList1 = new LinkedList<string>();

            linkedList1.AddLast("Zoya");
            linkedList1.AddLast("Shilpa");
            linkedList1.AddLast("Rohit");
            linkedList1.AddLast("Rohan");
            linkedList1.AddLast("Juhi");
            linkedList1.AddLast("Zoya");

            Console.WriteLine("This is a linked list output of strings:");

            foreach (var item in linkedList1)
            {
                Console.WriteLine(item);
            }

            //to remve the last node: 

            //Clear(): This method is used to remove all nodes from the LinkedList.
            //Remove(LinkedListNode): This method is used to remove the specified node from the LinkedList.
            //Remove(T): This method is used to remove the first occurrence of the specified value 
                       //from the LinkedList.
            //RemoveFirst(): This method is used to remove the node at the start of the LinkedList.
            //RemoveLast(): This method is used to remove the node at the end of the LinkedList.


            //Hashset









        }
    }
}

//Tutorial for all Array
using System;
using System.Collections; //To use ArrayList
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Regular array
            //Can only have 1 type per array
            //Create an array with different type
            string[] day = { "Mon", "Tue", "Wed", "Thur", "Fri", "Sat", "Sun" };
            int[] dayNum = { 0, 1, 2, 3, 4, 5, 6 };
            //Other array creations:
            //type[] array = new type[num]; //add value later
            //type[] array = new type[] {   }; //array without the size
            //type array = { };
            Console.WriteLine(day[6]);

            //array.Length
            //array.Sort() - sort by alphabetically and ascending order

            //System.Linq:
            //array.Max(), array.Min(), array.Sum()

            //Ouput all array using foreach loop
            /*foreach (var element in day)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();*/
            //Output array with seperator using array.Length
            /*for (int i = 0; i < day.Length; i++)
            {
                Console.Write(day[i]);
                if(i < day.Length -1 )
                {
                    Console.Write(", ");
                }
            }*/
            //Can also using String.Join() method
            //Command(String.Join(" ", arrayName));
            Console.WriteLine(String.Join(" ", day));

            //Convert to List using To.List()
            //List<int> nums = dayNum.ToList();
            //nums.ForEach(Console.WriteLine);

            //Array.ForEach() method
            //Array.ForEach(arrayName, command)
            //Array.ForEach(day, Console.WriteLine);

            //************ArrayList***************
            //Dynamic array. Elements can be added or removed from the Array List
            //at any point in time. Elements can be multiple types
            //Create Array List
            ArrayList a1 = new ArrayList();
            //ArrayList add element: ArrayList.Add(element)
            a1.Add(1);
            a1.Add("Hello");
            a1.Add(false);
            Console.WriteLine("ArrayList:");
            //ArrayList can use ForEach method
            foreach (var element in a1)
            {
                Console.WriteLine(element);
            }
            /*//Using Object
            foreach (Object objA in a1)
            {
                Console.WriteLine(objA);
            }*/
            //ArrayList command
            //Count: ArrayList.Count - return the number of elements of array
            Console.WriteLine("Counted elements: ");
            Console.WriteLine(a1.Count);
            //Contains: ArrayList.Contains(element) - return true if the element is present in the list
            Console.WriteLine("Does array contain: " + a1.Contains(1));
            //RemoveAt: ArrayList.RemoveAt(index) - remove an element from a specific position of the ArrayList
            Console.WriteLine("Pop at a1[1]:");
            Console.Write("Before: ");
            Console.WriteLine(a1[1]);
            a1.RemoveAt(1);
            Console.Write("After: ");
            Console.WriteLine(a1[1]);
            //Hello was removed at a1[1] and a1[2], True, replaced the position

            //************Stack************
            //Special case collection represents a Last In First Out(LIFO) concept.
            //LIFO - elements are on top of one another.
            //Adding new elements is called 'push' operation. To remove an element from a stack, you can 
            //also remove the top most element of the stack, this is called 'pop'.
            //Declaration of Stack
            Stack st = new Stack();

            //Adding element to stack, push operation - Stack.Push(element)
            st.Push(1);
            st.Push(2);
            st.Push(3);
            //Stack can use ForEach()
            Console.WriteLine("Stack:");
            foreach(Object obj in st)
            {
                Console.WriteLine(obj);
            } //Display bottom up
            //Count - Stack.Count //return the number of items in the Stack
            Console.WriteLine("Num of element in Stack: " + st.Count);
            //Contains - Stack.Contains(element) - return true/false whether the element is in the stack or not
            Console.Write("Is 3 in the stack: " + st.Contains(3));
            //Remove element from stack, pop operation - Stack.pop(); //top to bottom
            st.Pop();
            Console.WriteLine();
            Console.WriteLine("After pop:");
            foreach (Object obj in st)
            {
                Console.WriteLine(obj);
            } //Display bottom up

            //********Queue********
            //Special case collection represents FIFO concept.
            //The operation is similar to stack
            //Declare
            Queue qt = new Queue();
            //Adding elements - Queue.enqueue(elelment)            
            qt.Enqueue(1);
            qt.Enqueue("H");
            qt.Enqueue(false);
            Console.WriteLine("Queue");
            foreach(Object objQ in qt)
            {
                Console.WriteLine(objQ);
            }
            //Count - Queue.Count
            Console.WriteLine("Counted elements: " + qt.Count);
            //Contains - Queueu.Contains(element)
            Console.WriteLine("Does the queue contain" + qt.Contains("H"));
            //Remove elements - Queue.dequeue() - top to bottom
            qt.Dequeue();
            Console.WriteLine("Dequeue:");
            foreach(Object objQ in qt)
            {
                Console.WriteLine(objQ);
            }

            //*********Hashtable**********
            //Store key-value items. Store 2 values, which form an element of the hashtable
            //Example: {"001", ".Net"}
            //Declaration
            Hashtable ht = new Hashtable();
            //Adding - HashTable.add("Key", "value");
            //Element order is not guaranteed
            ht.Add("001", ".Net");
            ht.Add("002", 2);
            ht.Add("003", true);
            ht.Add("004", "Hello Hash");
            //Output
            Console.WriteLine("Hashtable:");
            ICollection keys = ht.Keys;
            foreach(Object k in keys)
            {
                Console.WriteLine(k + ": " + ht[k]);
            }
            //ContainsKey - Hashtable.Containskey(key)
            Console.WriteLine("ContainsKey");
            Console.WriteLine(ht.ContainsKey("001"));
            //ContainsValue - Hashtable.ContainsValue(value)
            Console.WriteLine("ContainValue");
            Console.WriteLine(ht.ContainsValue("Hello Hash"));



            Console.ReadKey();
        }
    }
}

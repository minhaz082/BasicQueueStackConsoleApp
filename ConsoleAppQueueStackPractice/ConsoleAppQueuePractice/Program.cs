using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppQueuePractice
{
    class Program
    {
        static void Main(string[] args)
        {
 //exercise of Queue

            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("hallow");
            myQueue.Enqueue("how");
            myQueue.Enqueue("are");
            myQueue.Enqueue("you ?");


            Console.Write("{0 } ", myQueue.Dequeue());
            //Console.Write("{0 } " , myQueue.Dequeue());
            //Console.Write("{0 } ", myQueue.Dequeue());
            //Console.Write("{0 } ", myQueue.Dequeue());
            Console.Write("{0 } ", myQueue.Peek());  // returns the next element

            
 /// exercise of stack
            //int count = 0;
            //Stack<string> mystack = new Stack<string>();
            //while (count<5)
            //{
            //    Console.Write(" enter value for stack :");
            //    string input = Convert.ToString(Console.ReadLine());
            //    mystack.Push(input);
            //    count++;                
            //}
            //Console.ReadKey();
            //Console.WriteLine("stack items following LIFO order are: ");
            //foreach (var item in mystack)
            //{
            //    Console.WriteLine(item);
            //} 
            Console.ReadKey();

        }
    }
}

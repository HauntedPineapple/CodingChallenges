using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList<string> myList = new SingleLinkedList<string>();
            myList.Add("Red");
            myList.Add("Blue");
            myList.Add("Green");
            myList.Add("Orange");
            myList.Add("Yellow");
            myList.Add("White");

            Console.WriteLine(">> Printing Contents:");
            for (int a = 0; a < myList.Count; a++)
            {
                Console.WriteLine(myList[a].Data);
            }

            //Console.WriteLine(">> Removing items");
            //try
            //{
            //    myList.Remove(0);
            //    myList.Remove(3);
            //    myList.Remove(5);
            //    myList.Remove(6);
            //}
            //catch (IndexOutOfRangeException i)
            //{
            //    Console.WriteLine(i.Message);
            //}

            //Console.WriteLine(">> Printing Contents After Removal:");
            //for (int a = 0; a < myList.Count; a++)
            //{
            //    Console.WriteLine(myList.GetData(a));
            //}

            Console.ReadLine();
        }
    }
}

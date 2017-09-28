using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefVal
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass1 myClass1 = new MyClass1();
            MyClass1 myClass2 = new MyClass1();
            MyStruct1 myStruct1 = new MyStruct1();
            MyStruct1 myStruct2 = new MyStruct1();

            if (myClass1 == myClass2)
            {
                Console.WriteLine("Yes for classes with ==");
            }
            else
            {
                Console.WriteLine("no for classes with ==");
            }
            if (myClass1.Equals(myClass2))
            {
                Console.WriteLine("Yes for classes with equals");
            }
            else
            {
                Console.WriteLine("no for classes with ==");
            }
            if (myStruct1 == myStruct2)
            {
                Console.WriteLine("yes for structs with ==");
            }
            else
            {
                Console.WriteLine("no for structs with ==");
            }
            if (myStruct1.Equals(myStruct2))
            {
                Console.WriteLine("yes for structs with equals");
            }
            else
            {
                Console.WriteLine("yes for structs with equals");
            }
            unsafe
            { Console.WriteLine(sizeof(MyStruct1));}
            Console.ReadKey();
        }  
    }      
 }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;

            for(int i=0;i<a;i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine("Hello! No :" + i);
                }
            }

            TestClass.greet();
            
            Console.ReadLine();
        }
    }
}

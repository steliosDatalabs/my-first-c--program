using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello World!! Just a test";

            Console.WriteLine(message);
            
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Value of i: {0}", i);
            }
        }
    }
}

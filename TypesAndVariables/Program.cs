using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World!");
            double number5 = 10.4;
            decimal number6 = 10.4M;
            char character = 'A';
            bool condition = true;
            byte number4 = 255;// 8bit
            short number3 = 32767;// 16bit 
            int number1 = 2147483647;// 32bit
            long number2 = 9223372036854775807;// 64 bit
            //var number7 = 10;

            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number4 is {0}", number5);
            Console.WriteLine("Number4 is {0}", number6);
            Console.WriteLine("Character is {0}", character);
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday=10,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }

}

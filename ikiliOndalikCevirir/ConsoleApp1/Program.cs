using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("ondalık bir sayı giriniz: ");
            int ond = int.Parse(Console.ReadLine());

            int kalan = 0;

            while (ond > 0)
            {
                kalan = ond % 2;
                Console.Write(kalan);
                ond /= 2;
            }

            Console.ReadLine();
        }

    }
}

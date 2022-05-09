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

            Console.Write("Sayı: ");
            int sayi = int.Parse(Console.ReadLine());

            string[] digits = { "sıfır", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
            int[] hane = new int[20];
            int kalan = 0,counter=0;

            while(sayi > 0)
            {
                kalan = sayi % 10;
                hane[counter] = kalan;
                counter++;
                sayi /= 10;
            }

            for(int i = counter-1; i >= 0; i--)
            {
                Console.Write(digits[hane[i]] + " ");
            }


            Console.ReadLine();
        }

    }
}

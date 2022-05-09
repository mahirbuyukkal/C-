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

            int kalan = 0,size=0,counter=0,sayi1=sayi;

            // basamak sayısı belirlendi
            while (sayi > 0)
            {
                sayi /= 10;
                size++;
            }
            int[] nums = new int[size];

            while (sayi1 > 0)
            {
                kalan = sayi1 % 10;
                nums[counter] = kalan;
                counter++;
                sayi1 /= 10;
            }

            Array.Reverse(nums);

            for(int i = 0; i < nums.Length; i++)
            {
                switch (nums[i])
                {
                    case 1:
                        Console.Write("bir ");
                        break;
                    case 2:
                        Console.Write("iki ");
                        break;
                    case 3:
                        Console.Write("üç ");
                        break;
                    case 4:
                        Console.Write("dört ");
                        break;
                    case 5:
                        Console.Write("beş ");
                        break;
                    case 6:
                        Console.Write("altı ");
                        break;
                    case 7:
                        Console.Write("yedi ");
                        break;
                    case 8:
                        Console.Write("sekiz ");
                        break;
                    case 9:
                        Console.Write("dokuz ");
                        break;
                    default:
                        break;


                }
            }


            Console.ReadLine();
        }

    }
}

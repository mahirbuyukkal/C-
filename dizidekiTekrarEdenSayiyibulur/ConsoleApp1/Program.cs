
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
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
            int[] arr;

            while (true)
            {
                Console.Write("Dizi boyutunu girin: ");
                bool flag = int.TryParse(Console.ReadLine(), out int size);
                if (flag) // size kontrolü
                {
                    if (size > 0)
                    {
                        arr = new int[size];
                        for(int i = 0; i < size;)
                        {
                            Console.Write("{0}. Değer: ", i + 1);
                            flag = int.TryParse(Console.ReadLine(), out int a);

                            if (flag) // dizi elemanı kontrolü
                            {
                                arr[i] = a;
                                i++;
                            }
                            else
                            {
                                Console.WriteLine("Lütfen sayı türünde bir değer girin.");
                            }
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Boyut negatif olamaz.");
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen sayı türünde bir değer girin.");
                }
            }

          tekrarEdenSayi(sirala(arr));

            Console.ReadLine();
        }
        static int[] sirala(int[] arr)
        {
            for(int i = 0; i < arr.Length-1; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    // 2,1,5,2,3
                    if(arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        // 1,2,5,2,3
                    }
                }
            }
            return arr;
        }
        static void tekrarEdenSayi(int[] arr)
        {

            int sayi = 0, tekrarS = 0, geciciT = 1;

            for(int i = 0; i < arr.Length - 1; i++)
            {
                if(arr[i] == arr[i + 1])
                {
                    geciciT++;
                }
                if(i==(arr.Length-2) || arr[i] != arr[i + 1])
                {
                    if (geciciT > tekrarS)
                    {
                        tekrarS = geciciT;
                        sayi = arr[i];
                    }
                    geciciT = 1;
                }
            }
           
            Console.WriteLine(sayi + " sayisi en çok tekrarlanmıştır. Ve bu sayı " + tekrarS + "  kez tekrar edilmiştir.");

        }
    }
   
}

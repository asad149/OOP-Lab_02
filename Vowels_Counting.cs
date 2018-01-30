using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication11
{
    class Vowels
    {


        public static void Counting_Vowels()
        {
            Console.WriteLine("\t\t\t************ Counting of Vowels ************\n\n ");
            int count = 0;
            char[] a = new char[10];
            Console.Write("Enter Any Name : ");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Console.ReadKey().KeyChar;

                if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u' || a[i] == 'A' || a[i] == 'E' || a[i] == 'I' || a[i] == 'O' || a[i] == 'U')
                {
                    count++;
                }
                
            }
            Console.WriteLine("\n\nVowels Present are {0}", count);
        }

       
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vowels.Counting_Vowels();

            Console.ReadLine();
        }
    }
}

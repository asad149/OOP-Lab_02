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
            int vowel = 0;
            int space = 0;
            int consonants = 0;
            Console.WriteLine("\t\t\t************ Counting of Vowels ************\n\n ");
            
            char[] a = new char[10];
            Console.Write("Enter Any Name : ");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Console.ReadKey().KeyChar;

                if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u' || a[i] == 'A' || a[i] == 'E' || a[i] == 'I' || a[i] == 'O' || a[i] == 'U')
                {
                    vowel++;
                }
                else if(char.IsWhiteSpace(a[i]))
                {
                    space++;
                }
                else
                {
                    consonants++;
                }
            }
            
        Console.WriteLine("\nYour total number of vowels is: {0}", vowel);
        Console.WriteLine("\nYour total number of constant is: {0}", consonants);
        Console.WriteLine("\nYour total number of space is: {0}", space);
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

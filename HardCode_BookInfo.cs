using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication10
{
    class Book
    {
        private string _authname;
        public string authname
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Author Name is not Valid");
                this._authname = value;
            }
            get
            {
                return this._authname;
            }
        }

        private string _bookname;
        public string bookname
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Book Name is not Valid");
                this._bookname = value;
            }
            get
            {
                return this._bookname;
            }
        }
        private short _year;
        public short year
        {
            set
            {
                if (value < 0)
                    throw new Exception("Value is not Valid");
                this._year = value;


            }
            get
            {
                return this._year;
            }
        }

        private int _noofpages;
        public int noofpages
        {
            set
            {
                if(value<0)
                    throw new Exception("Value is not Valid");
                this._noofpages = value;
            }
            get
            {
                return this._noofpages;
            }
        }

        private string _cover;
        public string cover
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Value is invalid");
                this._cover=value;
            }
            get
            {
                return this._cover;
            }
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            Book b = new Book();


            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;

            b.authname = "Asad";

            b.bookname = "C#";

            b.year = "1996";

            b.noofpages = 256;
            
            b.cover = "'H'";

         
            Console.Write("\t\t*************** Book's Information ***************\n ");
            Console.WriteLine("\nAuthor's Name is {0} ",b.authname);
            Console.WriteLine("\nBook's Name is {0}", b.bookname);
            Console.WriteLine("\nBook's Publish Year is {0}", b.year);
            Console.WriteLine("\nBook's No of Pages is {0}", b.noofpages);
            Console.WriteLine("\nBook's Cover is '{0}'", b.cover);




            Console.ReadLine();
        }
    }
}

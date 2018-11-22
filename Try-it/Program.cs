using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRequirement_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter book 1 details: ");
            string[] str = Console.ReadLine().Split(',');

            Book b = new Book(str[0], str[1], str[2], str[3], DateTime.ParseExact(str[4],"dd-MM-yyyy",null), double.Parse(str[5]));

            Console.WriteLine("Enter book 2 details: ");
            string[] str1 = Console.ReadLine().Split(',');
            Book b1 = new Book(str1[0], str1[1], str1[2], str1[3], DateTime.ParseExact(str[4], "dd-MM-yyyy", null), double.Parse(str1[5]));

            Console.WriteLine("Book 1");
            Console.WriteLine(b);
            Console.WriteLine("Book 2");
            Console.WriteLine(b1);

            if(b.Equals(b1))
                Console.WriteLine("Book 1 is same as Book 2");
            else
                Console.WriteLine("Book 1 and Book 2 are different");




        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the initial project.

            Console.WriteLine("Hello, World!");

            var input = Console.ReadLine();

            Console.WriteLine("You wrote: " + input);

            Console.WriteLine("Now write a calculation!");

            input = Console.ReadLine();

            int first = int.Parse(input.Split('+').First());
            int last = int.Parse(input.Split('+').Last());
            int sum = first + last;

            Console.WriteLine("The result is: " + sum);

            //Comment



        }
    }
}

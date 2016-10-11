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
            //Greeting
            Console.WriteLine("WELCOME!");

            //This is the initial project.

            Console.WriteLine("Hello, World!");

            var input = Console.ReadLine();

            Console.WriteLine("You wrote: " + input);

<<<<<<< HEAD
            Console.WriteLine("Now write a calculation!");

            input = Console.ReadLine();

            int first = int.Parse(input.Split('+').First());
            int last = int.Parse(input.Split('+').Last());
            int sum = first + last;

            Console.WriteLine("The result is: " + sum);

            //Comment



=======
            //I have now played around!
            //This is another awesome feature I just added
            
            
>>>>>>> Work_from_default
        }
    }
}

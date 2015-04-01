using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Type a Number.");
             var input1 = Console.ReadLine();

             Console.WriteLine("Please Type in a second Number.");
             var input2 = Console.ReadLine();

             var number1 = null;
             var number2 = null;
             do
             {
                 try
                 {
                     number1 = Int16.Parse(input1);
                 }
                 catch (Exception e)
                 {
                     Console.WriteLine("Stop Trolling");
                     input1 = Console.ReadLine();
                 }
             } while (number1 == null);

          var number2 = Int16.Parse(input2);

             Console.WriteLine("The sum is = " + (number1 + number2));

             Console.WriteLine("Press Any Key to Quit");
             Console.ReadKey();
        }
    }
}
using System;

namespace Excercise1102
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var test1 = new TestGenerics();

            Console.WriteLine(test1.Compare(1,4) ? "They are equals" : "They are not equals");

            var test2 = new TestGenerics();

            Console.WriteLine(test2.Compare("Hej","Hej") ? "They are equals" : "They are not equals");

            Console.ReadLine();
        }
    }
}

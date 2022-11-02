using System;

namespace Excercise1102
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var test1 = new TestGenerics();

            bool result = test1.Compare(1, 4);

            Console.WriteLine(result ? "They are equals" : "They are not equals");

            var test2 = new TestGenerics();

            bool result2 = test2.Compare("Hej", "Hej");

            Console.WriteLine(result2 ? "They are equals" : "They are not equals");

            Console.ReadLine();
        }
    }
}

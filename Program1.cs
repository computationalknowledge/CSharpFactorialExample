using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {   Factorial f1 = new Factorial();
            f1.recursion(5);
            Console.WriteLine("the answer is {0}", Factorial.recursionAnswer);
        }
    }

    class Factorial
    {
        public static int recursionAnswer;
        public void recursion(int a)
        {   // how can we pass the results of our recursive calculation
            // from one invocation of this method to the next?
            // order of operations
            // BO MD AS
            // bracketted operations
            // multiple and division
            // addition and subtraction
            //  how to pass the decremented version of a to next invocation of recursion method

            Factorial.recursionAnswer *= a;
            recursion(--a);
        }

    }
}

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {   Factorial f1 = new Factorial();
            f1.recursion(20);
            Console.WriteLine("the answer is {0}", Factorial.recursionAnswer);
        }
    }

    class Factorial
    {
        public static int recursionAnswer = 1;
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

            if (a == 1) { return; }
            else { 
            recursion(--a);}
        }

    }
}


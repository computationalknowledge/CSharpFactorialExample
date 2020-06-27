using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial f1 = new Factorial();

            f1.recursion(5);

        }
    }

    class Factorial
    {

        public void recursion(int a)
        {   // how can we pass the results of our recursive calculation
            // from one invocation of this method to the next?
            // order of operations
            // BO MD AS
            // bracketted operations
            // multiple and division
            // addition and subtraction

            int recursionAnswer = a * (a - 1);
            recursion(--recursionAnswer);
            
        }

    }
}

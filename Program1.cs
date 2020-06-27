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
            recursion(--a);
            
        }

    }
}

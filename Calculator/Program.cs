using System;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Calculator
    {
        public int Add(int v1, int v2)
        {
            int sum = v1 + v2;
            return sum;
        }

        public int Sub(int b3, int b4)
        {
            int sum = b3-b4;
            return sum;
        }
    }  
    
}

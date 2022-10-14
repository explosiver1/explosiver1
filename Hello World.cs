using System;

namespace HelloWorldApp
{
    class HelloWorld
    {
        static void Main(string[] args) {
        Console.WriteLine("Hello World");
        Console.Read();
        }





        public int Cost(int cost, double taxRate) {
            return cost + cost * taxRate;
        }


    }
}
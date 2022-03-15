using System;

namespace Hello
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string name = args[0];
            
            Console.WriteLine("Hello World{0}", name);
        }
    }
}

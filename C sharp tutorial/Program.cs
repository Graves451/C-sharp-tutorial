using System;

namespace C_sharp_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            HashtableExample o = new HashtableExample();
            o.add("franks", 1);
            Console.WriteLine(o.contains(2));
        }
    }
}

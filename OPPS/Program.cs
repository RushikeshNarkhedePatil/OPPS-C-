using System;

namespace OPPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MethodOverloading s1 = new MethodOverloading();
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.Add(10, 20));
            // single level inharitance
            Console.WriteLine();
            Console.WriteLine("Single_level Inharitance");
            SingleLevel1 r = new SingleLevel1();
            r.Add();
            r.Sub();
            r.Multi();
            r.Div();
            // Multi_Level Inharitance
            Console.WriteLine();
            Console.WriteLine("Multi_level Inharitance");
            MultiLevel2 m = new MultiLevel2();
            m.Add();
            m.Sub();
            m.Multi();
            m.Div();
            m.Mod();
        }
    }
}

using System;

namespace FactoryMethodRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            App app = new App(new ElfBlacksmith());
            app.ManufactureWeapons();

            Console.WriteLine(app.ToString());
        }
    }
}

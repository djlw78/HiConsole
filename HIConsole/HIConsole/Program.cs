using System;
using Commander;
namespace HIConsole
{
    class Program
    {
        public static CommandProcessor processor;
        static void Main(string[] args) => new Program().Run(args);

        public Program()
        {
            Console.WriteLine("HiConsole [Version 1.0.0.0b");
            Console.WriteLine("(c) 2020 Indie Developer. All rights reserved");
            processor = new CommandProcessor();
            processor.DefaultFGColor = ConsoleColor.White;
            processor.DefaultBGColor = ConsoleColor.Black;
            processor.ApplicationName = new AppName("HiConsole", new CommandVersion(1, 0, 0, 0, "b"));
        }

        public void Run(string[] args)
        {
            processor.Process(true);
        }
    }
}

using System;

namespace Singleton.App
{
    public static class CLI
    {
        private static void Print(string msg, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        public static void PrintInfo(string msg) => Print(msg, ConsoleColor.Blue);
        public static void PrintError(string msg) => Print(msg, ConsoleColor.Red);
    }
}
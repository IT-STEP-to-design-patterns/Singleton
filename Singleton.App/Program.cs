using System;
using System.ComponentModel;

namespace Singleton.App
{
    internal static class Program
    {
        private static void Main()
        {
            Single.Value = "Привет";
            CLI.PrintInfo($"{Single.Value}");
            
            Single.Value = "Hello";
            CLI.PrintError($"{Single.Value}");
        }
    }
}
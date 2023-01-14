/*
 * FirstProgram.cs
 * A simple program to demonstrate some basic concepts including:
 *   - header comments
 *   - in line comments
 *   - proper indenting
 *   - grouping of common code blocks
 *   - sequencing/order of code execution
 *   
 * Revision History
 *   - Tony Theodoropoulos, 2023.01.14: Created
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Tony");
            Console.WriteLine("Welcome to PROG1925");
            Console.ReadKey();

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("Springfield Nuclear Power");
            Console.WriteLine("Press Enter to Start Reactor");
            Console.ReadKey();

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("MELTDOWN HAPPENING. RUN AWAY!!!");
            Thread.Sleep(1000);

            Console.BackgroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("MELTDOWN HAPPENING. RUN AWAY!!!");
            Thread.Sleep(1000);

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("MELTDOWN HAPPENING. RUN AWAY!!!");
            Thread.Sleep(1000);

            Console.ReadKey();
        }
    }
}

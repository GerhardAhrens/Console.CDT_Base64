//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Lifeprojects.de">
//     Class: Program
//     Copyright © Lifeprojects.de 2025
// </copyright>
// <Template>
// 	Version 2.0.2025.0, 28.4.2025
// </Template>
//
// <author>Gerhard Ahrens - Lifeprojects.de</author>
// <email>developer@lifeprojects.de</email>
// <date>01.05.2025 20:01:09</date>
//
// <summary>
// Konsolen Applikation mit Menü Demo zum Base64 DataTyp
// </summary>
//-----------------------------------------------------------------------

namespace Console.CDT_Base64
{
    /* Imports from NET Framework */
    using System;

    public class Program
    {
        private static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("1. Menüpunkt 1");
                Console.WriteLine("2. Menüpunkt 2");
                Console.WriteLine("X. Beenden");
                Console.WriteLine("Wählen Sie einen Menüpunkt oder 'x' für beenden");
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.X)
                {
                    Environment.Exit(0);
                }
                else
                {
                    if (key == ConsoleKey.D1)
                    {
                        MenuPoint1();
                    }
                    else if (key == ConsoleKey.D2)
                    {
                        MenuPoint2();
                    }
                }
            }
            while (true);
        }

        private static void MenuPoint1()
        {
            Console.Clear();

            Console.WriteLine("Mit einer beliebigen Taste zurück zum Menü!");
            Console.ReadKey();
        }

        private static void MenuPoint2()
        {
            Console.Clear();

            Console.WriteLine("Mit einer beliebigen Taste zurück zum Menü!");
            Console.ReadKey();
        }
    }
}

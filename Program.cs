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
    using static System.Net.Mime.MediaTypeNames;

    public class Program
    {
        private static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("1. Erstellen eines Base64 String");
                Console.WriteLine("2. String Encode / Decode");
                Console.WriteLine("3. gültiger Base64 String");
                Console.WriteLine("4. falscher Base64 String");
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
                    else if (key == ConsoleKey.D3)
                    {
                        MenuPoint3();
                    }
                    else if (key == ConsoleKey.D4)
                    {
                        MenuPoint4();
                    }
                }
            }
            while (true);
        }

        private static void MenuPoint1()
        {
            Console.Clear();

            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string demoDataPath = Path.Combine(new DirectoryInfo(currentDirectory).Parent.Parent.Parent.FullName, "DemoData");
            string demoDataImage = Path.Combine(new DirectoryInfo(currentDirectory).Parent.Parent.Parent.FullName, "DemoData", "Demo.png");

            if (File.Exists(demoDataImage))
            {
                Base64 base64String = ImageToBase64(demoDataImage);
                bool isValid = base64String.IsBase64String();
                if (isValid == true)
                {
                    string text = isValid == true ? "gültig" : "nicht gültig";
                    Console.WriteLine($"Base64 String ist {text}");
                    int size = base64String.Length;
                    Console.WriteLine($"Base64 String ist {size} Zeichen lang");

                    System.Drawing.Image photo = Base64ToImage(base64String);
                    photo.Save($"{demoDataPath}\\DemoSave.png", System.Drawing.Imaging.ImageFormat.Png);
                    Console.WriteLine($"Image-Datei aus Base64 gelesen und unter {demoDataPath}\\DemoSave.png gespeichert");
                }
            }


            Console.WriteLine("Mit einer beliebigen Taste zurück zum Menü!");
            Console.ReadKey();
        }

        private static void MenuPoint2()
        {
            const string TEXT = "Hallo Gerhard";
            Console.Clear();

            Base64 base64String = Base64.Base64Encode("hallo Gerhard");
            bool isValid = base64String.IsBase64String();
            if (isValid == true)
            {
                string text = isValid == true ? "gültig" : "nicht gültig";
                Console.WriteLine($"Base64 String ist {text}");
                int size = base64String.Length;
                Console.WriteLine($"Base64 String ist {size} Zeichen lang");

                string decodeText = Base64.Base64Decode(base64String);
                string textResult = decodeText == TEXT ? "gleich" : "ungleich";
                Console.WriteLine($"Decode String ist {text}");
            }

            Console.WriteLine("Mit einer beliebigen Taste zurück zum Menü!");
            Console.ReadKey();
        }

        private static void MenuPoint3()
        {
            Console.Clear();

            Base64 base64String = "aGFsbG8gR2VyaGFyZA==";
            bool base64StringValid = base64String.IsBase64String();
            string validText = base64StringValid == true ? "Ja" : "Nein";
            Console.WriteLine($"Der String ist Base64 kodiert: {validText}");

            Console.WriteLine("Mit einer beliebigen Taste zurück zum Menü!");
            Console.ReadKey();
        }

        private static void MenuPoint4()
        {
            Console.Clear();

            Base64 base64String = "aGFsbG8gR2VyaGFyZ==";
            bool base64StringValid = base64String.IsBase64String();
            string validText = base64StringValid == true ? "Ja" : "Nein";
            Console.WriteLine($"Der String ist Base64 kodiert: {validText}");

            Console.WriteLine("Mit einer beliebigen Taste zurück zum Menü!");
            Console.ReadKey();
        }

        #region Image Hilfsmethoden
        public static Base64 ImageToBase64(string imageFile)
        {
            System.Drawing.Image img = System.Drawing.Image.FromFile(imageFile);
            if (File.Exists(imageFile) == true)
            {
                using (var ms = new MemoryStream())
                {
                    img.Save(ms, img.RawFormat);
                    return Convert.ToBase64String(ms.ToArray());
                }
            }

            return new Base64(string.Empty);
        }

        public static System.Drawing.Image Base64ToImage(Base64 base64String)
        {
            System.Drawing.Image result = null;
            if (base64String.IsNullOrEmpty == false)
            {
                byte[] imageBytes = System.Convert.FromBase64String(base64String.Value);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    result = System.Drawing.Image.FromStream(ms);
                }
            }

            return result;
        }
        #endregion Image Hilfsmethoden
    }
}

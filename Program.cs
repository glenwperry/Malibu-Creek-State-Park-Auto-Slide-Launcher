using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocentSlideshow
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stillRunning = true;

            string selection = null;

            string openOfficePath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\OpenOffice 4\\program\\simpress.exe";

            while (stillRunning)
            {
                Console.WriteLine("Which slideshow would you like to see?");
                Console.WriteLine("1. Malibu Creek Loop");
                Console.WriteLine("2. MASH Site");
                Console.WriteLine("3. Circle X Ranch");
                Console.WriteLine("4. Century Lake");
                Console.WriteLine("5. Flora and Fauna");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        selection = "\"C:\\Users\\Glen William Perry\\Documents\\presentations\\malibucreek.pps\"";
                        stillRunning = false;
                        break;
                    case "2":
                        selection = "\"C:\\Users\\Glen William Perry\\Documents\\presentations\\mashsite.pps\"";
                        stillRunning = false;
                        break;
                    case "3":
                        selection = "\"C:\\Users\\Glen William Perry\\Documents\\presentations\\circlex.pps\"";
                        stillRunning = false;
                        break;
                    case "4":
                        selection = "\"C:\\Users\\Glen William Perry\\Documents\\presentations\\centurylake.pps\"";
                        stillRunning = false;
                        break;
                    case "5":
                        stillRunning = false;
                        selection = "\"C:\\Users\\Glen William Perry\\Documents\\presentations\\floraandfauna.pps\"";
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please select 1, 2, 3, 4 or 5 and press the enter key.");
                        input = Console.ReadLine();
                        break;
                }
            }
            var startInfo = new ProcessStartInfo(openOfficePath)
            {
                WindowStyle = ProcessWindowStyle.Maximized,
                Arguments = selection
            };

            Process.Start(startInfo);
        }
    }
}

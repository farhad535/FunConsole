using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FunConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CountdownTimer(10, interval: 2);
            Console.ReadKey();
        }
        static void CountdownTimer(int start, int finish = 0, int interval = 1)
        {
            InitialSetting();
            for (int i = start; i >= finish; i -= interval)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                WritrTitle();
                Console.CursorLeft = Console.BufferWidth / 2 + 3;
                Console.CursorSize = 50;
                Console.CursorVisible = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(i);
                Console.Beep(5000, 500);
                Thread.Sleep(1000);
            }
            ImgFun();
        }
        static void InitialSetting()
        {
            Console.Title = "FUN";
            Console.SetWindowSize(100, 50);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        static void WritrTitle()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t    ▄▄▄▄    ▒█████   ███▄ ▄███▓ ▄▄▄▄   ");
            Console.WriteLine("\t\t\t\t   ▓█████▄ ▒██▒  ██▒▓██▒▀█▀ ██▒▓█████▄ ");
            Console.WriteLine("\t\t\t\t   ▒██▒ ▄██▒██░  ██▒▓██    ▓██░▒██▒ ▄██");
            Console.WriteLine("\t\t\t\t   ▒██░█▀  ▒██   ██░▒██    ▒██ ▒██░█▀  ");
            Console.WriteLine("\t\t\t\t   ░▓█  ▀█▓░ ████▓▒░▒██▒   ░██▒░▓█  ▀█▓");
            Console.WriteLine("\t\t\t\t   ░▒▓███▀▒░ ▒░▒░▒░ ░ ▒░   ░  ░░▒▓███▀▒");
            Console.WriteLine("\t\t\t\t   ▒░▒   ░   ░ ▒ ▒░ ░  ░      ░▒░▒   ░ ");
            Console.WriteLine("\t\t\t\t    ░    ░ ░ ░ ░ ▒  ░      ░    ░    ░ ");
            Console.WriteLine("\t\t\t\t    ░          ░ ░         ░    ░      ");
            Console.WriteLine("\t\t\t\t         ░                           ░ ");
        }
        static void ImgFun()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                          ▄██▓▓▓▓▓█▄µ");
            Console.WriteLine("                                         ▓▓▀▀-.   ─\"▀▀█");
            Console.WriteLine("                   ,▄██▓▓█        , e▄▄██████████▄▄▄▄,  >");
            Console.WriteLine("                 ▄▓▓▓▀▀─    ▄▄█▀▀▀²─       z▄⌐     ─²▀▀▓██▄▄,");
            Console.WriteLine("                █▓▀-    ▄█▀▀─             ▐▓              -▀▀▓█▄,");
            Console.WriteLine("               ▐▓`  ,▄▀▀       æ▀█▄       ▐─     ▄▄█▓▓▓▓▓▓▓▓██▄▀▓▓█▄");
            Console.WriteLine("               ▓ ,▄█▀             -▀       ▌   ▄▓▓▀,▄▄▄▄▄,  .\"▀▓█ ╙▓▓█µ");
            Console.WriteLine("               ▄█▀.                 ╙      T  ▓▓▓▄█▀-                ▀▓▓▄");
            Console.WriteLine("             ▄█▀          ,▄▄▄▄▄▄▄▄         ⌐▀▀²─                      ▀▓▓▄");
            Console.WriteLine("           ;▓▀         ▄█▓▓▓▀▀▀▀▀▓▓▓▓█∞                            ▄▄▄   ▀▓▓▄");
            Console.WriteLine("          █▓        ;█▓▓▀ ,▄▀▀▀▀▀▀²².                             \"▓▓▀▓    ▓▓█");
            Console.WriteLine("         ▓▀        █▓▓- ,▀▀                                      ▄▓▓▓       ▀▓▓¿");
            Console.WriteLine("       ,▓╜        ▓▓                                          ▄█▓▓▓▓`        `▓▓▄");
            Console.WriteLine("       ▓╛        █╛                                         ▄▓▓▓▓▓▓▓          \"▓▓µ");
            Console.WriteLine("      ▓▌                                                ,▄█▓▓▓▓▓▓▓▓▌           ▐▓▓");
            Console.WriteLine("     ▐▓               ▄██                       ,a▄▄██▓▓▓▓▓▓▓▓▓▓▓▓▓             ▓▓▓");
            Console.WriteLine("     ▓▌              █▓▓▓▓▓▓▓▓▓▓▓████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓              ▓▓⌐");
            Console.WriteLine("    ▐▓                  ▀▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▌              ▓▓▓");
            Console.WriteLine("    ▓▓                   ╘▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓─              ▐▓▓");
            Console.WriteLine("    ▄\"                     ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓                ▄▄");
            Console.WriteLine("    ▓▌                      ²▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓               ¬▓▓");
            Console.WriteLine("    ▓▓                        ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓               ▐▓▓");
            Console.WriteLine("    ▐▓                         \"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▌              █▓▓");
            Console.WriteLine("     ▓                           ▀▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓              ▓▓▌");
            Console.WriteLine("     ▓█                            ▀▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓             ▐▓▓");
            Console.WriteLine("      ▓µ                             ▀▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓             ▓▓▌");
            Console.WriteLine("      ▐▓                               ▀▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓─            ▓▓▓");
            Console.WriteLine("       ▀▓                                ²▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▀            █▓▓");
            Console.WriteLine("        ▀▓                                  ▀▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▀             █▓▀");
            Console.WriteLine("         ╘▓▄                                   `▀▀▓▓▓▓▓▓▓▀▀\".              ╓▓▓╛");
            Console.WriteLine("           ▀█                                   `╨▀æ▄▄▄▄██▀─              █▓▓");
            Console.WriteLine("            .▓▄                                                         ▄▓▓─");
            Console.WriteLine("              -▓█                                                     ▄▓▓\"");
            Console.WriteLine("                 ▀█▄                                               ▄█▓▓`");
            Console.WriteLine("                   `▀█▄                                         ▄█▓▓▀");
            Console.WriteLine("                      ─▀█▄▄                                 z▄█▓▀²");
            Console.WriteLine("                          `▀▀█▄▄,                     ,▄▄█▓▓▀\"");
            Console.WriteLine("                               -╙▀▀▓█████▄▄▄▄▄▄█████▀──²─");
        }
    }
}

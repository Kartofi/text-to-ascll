using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ASCII_art_from_text
{
    class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            Console.Write("Type the text you want to convert: ");
            char[] chars = Console.ReadLine().ToLower().ToCharArray();
            string alphabet = "/ abcdefghijklmnopqrstuvwxyz";
            string final = "";
            string[] ascil = new string[28] {
                "     __\n   _/_/\n _/_/\n/_/\n       ",
                "\n\n\n\n",
                "   ___ \n  / _ |\n / __ |\n/_/ |_|\n       ",
                "   ___ \n  / _ )\n / _ |\n/____/ \n       ",
                "  _____\n / ___/\n/ /__  \n\\___/\n       ",
                "   ___ \n  / _ \\\n / // /\n/____/\n       ",
                "   ____\n  / __/\n / _/\n/___/\n       ",
                "   ____\n  / __/\n / _/\n/_/\n       ",
                "  _____\n / ___/\n/ (_ /\n\\___/\n       ",
                "   __ __\n  / // /\n / _  /\n/_//_/  \n        ",
                "   ____\n  /  _/\n _/ /\n/___/\n       ",
                "     __\n __ / /\n/ // / \n\\___/\n      ",
                "   __ __\n  / //_/\n / ,<\n/_/|_|\n        ",
                "   __ \n  / /\n / /__\n/____/\n      ",
                "   __  ___\n  /  |/  /\n / /|_/ /\n/_/  /_/\n          ",
                "   _  __\n  / |/ /\n /    /\n/_/|_/\n        ",
                "  ____ \n / __ \\\n/ /_/ /\n\\____/\n       ",
                "   ___ \n  / _ \\\n / ___/\n/_/\n       ",
                "  ____ \n / __ \\\n/ /_/ /\n\\___\\_\\\n       ",
                "   ___ \n  / _ \\\n / , _/\n/_/|_|\n       ",
                "   ____\n  / __/\n _\\ \\  \n/___/\n       ",
                " ______\n/_  __/\n / /\n/_/\n       ",
                "  __  __\n / / / /\n/ /_/ /\n\\____/\n        ",
                "  _   __\n | | / /\n | |/ /\n |___/\n        ",
                "  _      __\n | | /| / /\n | |/ |/ /\n |__/|__/\n           ",
                "   _  __\n  | |/_/\n _>  <\n/_/|_|\n        ",
                " __  __\n \\ \\/ /\n  \\  /\n  /_/\n       ",
                "  ____\n /_  /\n  / /_\n /___/\n      "

            };
            for (int i =0; i<chars.Length;i++)
            {
                
                final += "\n" + ascil[alphabet.IndexOf(chars[i])];
                
            }

            Clipboard.SetText(final);
            Console.Write(final);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AnswerConverter
{
    class miscellaneous
    {
        //https://stackoverflow.com/questions/12847960/centering-text-in-c-sharp-console-app-only-working-with-some-input
        public static void centerText(String text)
        {
            Console.Write(new string(' ', (Console.WindowWidth - text.Length) / 2));
            Console.WriteLine(text);
        }
        public static void Header(string title, string subtitle = "", ConsoleColor color = ConsoleColor.White)
        {
            int windowWidth = 90 - 2;
            string titleContent = String.Format("║{0," + ((windowWidth / 2) + (title.Length / 2)) + "}{1," + (windowWidth - (windowWidth / 2) - (title.Length / 2) + 1) + "}", title, "║");
            string subtitleContent = String.Format("║{0," + ((windowWidth / 2) + (subtitle.Length / 2)) + "}{1," + (windowWidth - (windowWidth / 2) - (subtitle.Length / 2) + 1) + "}", subtitle, "║");

            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine(titleContent);
            if (!string.IsNullOrEmpty(subtitle))
            {
                Console.WriteLine(subtitleContent);
            }
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════╗");
        }
        /*   public static void Header(string title, string subtitle = "", ConsoleColor foreGroundColor = ConsoleColor.White, int windowWidthSize = 90)
        {
            Console.Title = title + (subtitle != "" ? " - " + subtitle : "");
            string titleContent = CenterText(title, "║");
            string subtitleContent = CenterText(subtitle, "║");
            string borderLine = new String('═', windowWidthSize - 2);

            Console.ForegroundColor = foreGroundColor;
            Console.WriteLine($"╔{borderLine}╗");
            Console.WriteLine(titleContent);
            if (!string.IsNullOrEmpty(subtitle))
            {
                Console.WriteLine(subtitleContent);
            }
            Console.WriteLine($"╚{borderLine}╝");
            Console.ResetColor();
        }

       */
        /// <summary>
        /// Align content to center for console. Can be used with decoration if used inside menu or header
        /// </summary>
        /// <param name="content">Content to center</param>
        /// <param name="decorationString">Left and right decoration, default is empty/none</param>
        /// <returns>Center aligned text</returns>
        public static string CenterText(string content, string decorationString = "", int windowWidthSize = 90)
        {
            int windowWidth = windowWidthSize - (2 * decorationString.Length);
            return String.Format(decorationString + "{0," + ((windowWidth / 2) + (content.Length / 2)) + "}{1," + (windowWidth - (windowWidth / 2) - (content.Length / 2) + decorationString.Length) + "}", content, decorationString);
        }
    }
}

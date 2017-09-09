using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConnectFour
{
    /// <summary>
    /// Provides extensions to Console class.
    /// </summary>
    public static class ConsoleWindowHelper
    {
        public static int ConsoleWindowWidth { get; set; }
        public static int ConsoleWindowHeight { get; set; }
        public static ConsoleColor ConsoleWindowForeground { get; set; }
        public static ConsoleColor ConsoleWindowBackground { get; set; }
        public static ConsoleColor HeaderForeground { get; set; }
        public static ConsoleColor HeaderBackground { get; set; }

        /// <summary>
        /// initialize the console window to the default values
        /// </summary>
        /// <param name="consoleWindowWidth">console window width</param>
        /// <param name="consoleWindowHeight">console window height</param>
        /// <param name="consoleWindowForeground">console window text color</param>
        /// <param name="consoleWindowBackground">console window background color </param>
        public static void InitializeConsoleWindow()
        {
            //
            // set default values for console window from layout class
            //
            ConsoleWindowWidth = ConsoleLayout.WindowWidth;
            ConsoleWindowHeight = ConsoleLayout.WindowHeight;

            //
            // set default values for console window from theme class
            //
            ConsoleWindowForeground = ConsoleTheme.WindowForegroundColor;
            ConsoleWindowBackground = ConsoleTheme.WindowBackgroundColor;
            HeaderBackground = ConsoleTheme.HeaderBackgroundColor;
            HeaderForeground = ConsoleTheme.HeaderForegroundColor;

            //
            // set initial position of console window
            //
            Console.SetWindowPosition(ConsoleLayout.WindowPositionLeft, ConsoleLayout.WindowPositionTop);

            //
            // set console window to default values
            //
            ResetConsoleWindow();

        }

        public static void ResetConsoleWindow()
        {
            Console.WindowWidth = ConsoleWindowWidth;
            Console.WindowHeight = ConsoleWindowHeight;
            Console.ForegroundColor = ConsoleWindowForeground;
            Console.BackgroundColor = ConsoleWindowBackground;
            Console.Clear();
        }
    }
}

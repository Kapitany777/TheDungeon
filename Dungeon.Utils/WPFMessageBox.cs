using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Dungeon.Utils
{
    /// <summary>
    /// WPF Message boxes
    /// </summary>
    public static class WPFMessageBox
    {
        /// <summary>
        /// Displays an error message
        /// </summary>
        /// <param name="text">The text of the error message</param>
        public static void Error(string text)
        {
            MessageBox.Show(text, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        /// <summary>
        /// Displays an error message in two lines
        /// </summary>
        /// <param name="text1">The first line of the error message</param>
        /// <param name="text2">The second line of the error message</param>
        public static void Error(string text1, string text2)
        {
            Error($"{text1}{Environment.NewLine}{text2}");
        }

        /// <summary>
        /// Displays an error message and an exception
        /// </summary>
        /// <param name="text">The text of the error message</param>
        /// <param name="ex">The exception</param>
        public static void Error(string text, Exception ex)
        {
            Error(text, ex.Message);
        }

        /// <summary>
        /// Displays a warning message
        /// </summary>
        /// <param name="text">The text of the warning message</param>
        public static void Warning(string text)
        {
            MessageBox.Show(text, "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        /// <summary>
        /// Displays a warning message in two lines
        /// </summary>
        /// <param name="text1">The first line of the warning message</param>
        /// <param name="text2">The second line of the warning message</param>
        public static void Warning(string text1, string text2)
        {
            Warning($"{text1}{Environment.NewLine}{text2}");
        }

        /// <summary>
        /// Displays an information message
        /// </summary>
        /// <param name="text">The text of the info message</param>
        public static void Info(string text)
        {
            MessageBox.Show(text, "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /// <summary>
        /// Displays an information message in two lines
        /// </summary>
        /// <param name="text1">The first line of the information message</param>
        /// <param name="text2">The second line of the information message</param>
        public static void MsgInfo(string text1, string text2)
        {
            Info($"{text1}{Environment.NewLine}{text2}");
        }

        /// <summary>
        /// Confirmation (Yes / No)
        /// </summary>
        /// <param name="text">The text of the message</param>
        /// <returns>The user's choice</returns>
        public static MessageBoxResult Confirmation(string text)
        {
            return MessageBox.Show(text, "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Utils
{
    public static class Directories
    {
        /// <summary>
        /// The name of the company
        /// </summary>
        public static string CompanyName => FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location).CompanyName;

        /// <summary>
        /// The name of the product
        /// </summary>
        public static string ProductName => FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location).ProductName;

        /// <summary>
        /// The local application directory
        /// </summary>
        public static string LocalApplicationData => Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

        /// <summary>
        /// The directory of the program
        /// </summary>
        public static string ProductData => $@"{LocalApplicationData}\{CompanyName}\{ProductName}";

        /// <summary>
        /// The settings directory
        /// </summary>
        public static string Settings => $@"{ProductData}\Settings";

        /// <summary>
        /// The save games directory
        /// </summary>
        public static string SaveGames => $@"{ProductData}\SaveGames";

        /// <summary>
        /// The MyDocuments directory
        /// </summary>
        public static string MyDocuments => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    }
}

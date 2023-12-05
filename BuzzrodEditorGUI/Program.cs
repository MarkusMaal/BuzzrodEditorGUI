using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuzzrodEditorGUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static string wikiURL = "https://fishingfantasy.fandom.com/wiki/";
        public static string fileName;
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            fileName = "";
            if (args.Length > 0)
            {
                fileName = args[0];
            }
            Application.Run(new Form1());
        }
    }
}

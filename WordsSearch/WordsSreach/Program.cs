using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WordsSearch
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            int count = Count<string>(args);
            string path = "";
            if (count == 0)
            {
                Application.Run(new frm_Main());
            }
            else
            {
                for (int i = 0; i < count; i++) path = path + args[i] + " ";
                Application.Run(new frm_Main(path));
            }
        }
        static int Count<T>(T[] input)
        {
            int i = 0;
            try
            {
                while (true)
                {
                    T tmp = input[i];
                    i++;
                }
            }
            catch { return i; }
        }
    }
}
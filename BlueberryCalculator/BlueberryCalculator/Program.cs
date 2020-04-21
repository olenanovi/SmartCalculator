using AnalaizerClass;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BlueberryCalculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                ConsoleApiFunction.AllocConsole();

                Brain.expression = args[0];

                var result = Brain.Estimate();

                Console.WriteLine("Input:\t\t{0}", args[0]);

                Console.WriteLine("Output:\t\t{0}", result);

                Console.ReadKey();
            }
            else
            {
                Application.EnableVisualStyles();

                Application.SetCompatibleTextRenderingDefault(false);

                Application.Run(new CalcForm());
            }
        }
    }

    internal static class ConsoleApiFunction
    {
        [DllImport("kernel32.dll")]
        internal static extern bool AllocConsole();
    }
}
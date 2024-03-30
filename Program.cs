using System;
using System.Diagnostics;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace hotel
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            string databaseName = "hotel_manager";
            string userName = "root";
            string password = "root";
            string dumpFile = "dump.sql";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "mysqldump",
                RedirectStandardInput = false,
                RedirectStandardOutput = true,
                Arguments = $"-u {userName} -p{password} {databaseName} -r {dumpFile}",
                UseShellExecute = false
            };

            Process process = Process.Start(psi);
            process.WaitForExit();

            Console.WriteLine("Database dumped to " + dumpFile);
        }
    }
}

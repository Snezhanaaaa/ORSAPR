using KompasApi;
using Microsoft.VisualBasic.Devices;
using Rook;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessRookUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
            StressTest();
        }
            public static void StressTest()
            {
                RookInfo _rookInfo = new RookInfo
                {
                    FullHeight = 70,
                    LowerBaseDiameter = 20,
                    UpperBaseDiameter = 15,
                    LowerBaseHeight = 15,
                    UpperBaseHeight = 14

                };
                KompasConnector _kompas = new KompasConnector();

                var stopWatch = new Stopwatch();
                stopWatch.Start();
                var streamWriter = new StreamWriter($"D:\\log.txt", true);
                Process currentProcess = System.Diagnostics.Process.GetCurrentProcess();
                var count = 0;
                while (true)
                {
                    ModelCreator _modelCreator = new ModelCreator();
                    _modelCreator.CreateRook(_rookInfo);
                    var computerInfo = new ComputerInfo();
                    var usedMemory = (computerInfo.TotalPhysicalMemory - computerInfo.AvailablePhysicalMemory) *
                        0.0000000000931322574615478515625;
                    streamWriter.WriteLine(
                        $"{++count}\t{stopWatch.Elapsed:hh\\:mm\\:ss}\t{usedMemory}");
                    streamWriter.Flush();
                }

            }
        }
}

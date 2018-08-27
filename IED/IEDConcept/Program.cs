using IEDConcept.Model;
using IEDConcept.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Permissions;

namespace IEDConcept
{
    public class Program
    {
        static void Main(string[] args)
        {   
            //Obter IED na inicialização da REDE
            Parameters IED = new Parameters();
            /*
            IED.ID = "0";
            IED.SN = "0000000";
            IED.NAME = "IED";
            IED.EUI = "0000000";

            IED.IA = 20;
            IED.IB = 20;
            IED.IC = 20;
            IED.IN = 0;
            IED.IG = 0;
            IED.VA = 127;
            IED.VB = 127;
            IED.VC = 127;
            IED.VN = 0;
            IED.VG = 0;

            IED.ONOFF = true;
            IED.OPENCLOSE = true;

            IED.Type = Tools.IEDType.Breaker;

            Tools.Exportar("sensor.xml", IED);
            */
            Run();
        }

        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        public static void Run()
        {
            /*
            string[] args = System.Environment.GetCommandLineArgs();

            // If a directory is not specified, exit program.
            if (args.Length != 2)
            {
                // Display the proper way to call the program.
                Console.WriteLine("Usage: Watcher.exe (directory)");
                return;
            }
            *

            // Create a new FileSystemWatcher and set its properties.
            
            watcher.Path = args[1];
            /* Watch for changes in LastAccess and LastWrite times, and
               the renaming of files or directories. */
            FileSystemWatcher watcher = new FileSystemWatcher("D:\\Desenvolvimento\\cursosdev\\IED\\IEDConcept\\bin\\Debug", "*.xml");
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;

            // Add event handlers.
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            // Begin watching.
            watcher.EnableRaisingEvents = true;

            // Wait for the user to quit the program.
            Console.WriteLine("Press \'q\' to quit the sample.");
            while (Console.Read() != 'q') ;
        }

        // Define the event handlers.
        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            Parameters IED = new Parameters();
            IED = Tools.Importar(e.FullPath);
            
            // Specify what is done when a file is changed, created, or deleted.
            if (IED != null)
            {
                IED.Protected();
                Console.Clear();
                Console.WriteLine("NAME: " + IED.NAME + " " + e.ChangeType);
                Console.WriteLine("IA: " + IED.IA + " " + e.ChangeType);
                Console.WriteLine("IB: " + IED.IB + " " + e.ChangeType);
                Console.WriteLine("IC: " + IED.IC + " " + e.ChangeType);
                Console.WriteLine("IN: " + IED.IN + " " + e.ChangeType);
                Console.WriteLine("IG: " + IED.IG + " " + e.ChangeType);
                Console.WriteLine("VA: " + IED.VA + " " + e.ChangeType);
                Console.WriteLine("VB: " + IED.VB + " " + e.ChangeType);
                Console.WriteLine("VC: " + IED.VC + " " + e.ChangeType);
                Console.WriteLine("VG: " + IED.VG + " " + e.ChangeType);
                Console.WriteLine("VN: " + IED.VN + " " + e.ChangeType);

                Console.WriteLine("ON: " + IED.ONOFF + " " + e.ChangeType);
                Console.WriteLine("CLOSE: " + IED.OPENCLOSE + " " + e.ChangeType);

            }            
        }

        private static void OnRenamed(object source, RenamedEventArgs e)
        {
            Parameters IED = new Parameters();

            // Specify what is done when a file is renamed.
            Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
        }
    }
}

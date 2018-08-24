using IEDConcept.Model;
using IEDConcept.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEDConcept
{
    public class Program
    {
        FileSystemWatcher fsw = new FileSystemWatcher();
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
            while (true)
            {
                IED = Tools.Importar("sensor.xml");
                Console.WriteLine(IED.IA);
            }            
            //Console.ReadLine();
        }
    }
}

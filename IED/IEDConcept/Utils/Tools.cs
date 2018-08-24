using IEDConcept.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IEDConcept.Utils
{
    public class Tools
    {
        public enum IEDType  { Breaker, ShuntCompensator, Sectionaliser, Swicth, Fuse, PowerTransformer};

        public static bool Exportar(string caminho, Parameters abstractobj)
        {
            try
            {
                FileStream stream = new FileStream(caminho, FileMode.Create);
                XmlSerializer serializador = new XmlSerializer(typeof(Parameters));
                serializador.Serialize(stream, abstractobj);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Parameters Importar(string caminho)
        {
            try
            {
                FileStream stream = new FileStream(caminho, FileMode.Open);
                XmlSerializer desserializador = new XmlSerializer(typeof(Parameters));
                Parameters abstractobj = (Parameters)desserializador.Deserialize(stream);
                stream.Close();
                return abstractobj;
            }
            catch
            {
                return null;
            }
        }
    }
}

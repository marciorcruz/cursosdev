using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IEDConcept.Utils.Tools;

namespace IEDConcept.Model
{
    public class Parameters
    {
        public String ID { get; set; }
        public String NAME { get; set; }
        public String SN { get; set; }
        public String EUI { get; set; }

        public Double ICC { get; set; }

        public Double VA { get; set; }
        public Double VB { get; set; }
        public Double VC { get; set; }
        public Double VN { get; set; }
        public Double VG { get; set; }

        public Double IA { get; set; }
        public Double IB { get; set; }
        public Double IC { get; set; }
        public Double IN { get; set; }
        public Double IG { get; set; }

        public Boolean OPENCLOSE { get; set; }
        public Boolean ONOFF { get; set; }

        public IEDType Type { get; set; }

        public Double Temperature { get; set; }

        public void Protected()
        {
            if (IA > ICC || IB > ICC || IC > ICC || IG > 0 || IN > ICC)
            {
                OPENCLOSE = false;
            }
        }
    }
}

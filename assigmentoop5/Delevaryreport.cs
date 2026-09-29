using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigmentoop5
{
    internal class Delevaryreport
    {
        public void printshipment(ITrackable shipment)
        {
            Console.WriteLine(shipment.gettrackingstatus);
        }
        public void printinsurance(IInsurable shipment)
        {
            Console.WriteLine(shipment.calculateinsurance);
        }
    }
}
    


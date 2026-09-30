using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigmentoop5
{
    internal static  class shipmentextention
    {
        public static string getsummary(this Shipment shipment)
        {
            return $"tarckingcode:{shipment.trackingcode},shipmenttype:{shipment.GetType().Name},weitgt:{shipment.weight},statuts:{shipment.gettrackingstatus}";

        }
       public static bool isdeleverd(this Shipment shipment)
        {
            return shipment.gettrackingstatus() == "delevered";
        }
    }
}

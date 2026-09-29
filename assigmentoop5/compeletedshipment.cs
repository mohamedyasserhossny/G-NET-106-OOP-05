using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigmentoop5
{
    internal sealed class compeletedshipment:Shipment
    {
        public compeletedshipment(string Trackingcode, string Description, decimal Weight, decimal Delevaryfee, Delevaryadress Destiontion) : base(Trackingcode, Description, Weight, Delevaryfee, Destiontion)
        {
        }

        public override decimal estimatedcost => throw new NotImplementedException();

        public override void printshipment()
        {
            throw new NotImplementedException();
        }
    }
}


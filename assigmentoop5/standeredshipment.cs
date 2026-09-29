using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigmentoop5
{
    internal class standeredshipment:Shipment, ITrackable, IInsurable
    {
        public standeredshipment(string Trackingcode, string Description, decimal Weight, decimal Delevaryfee, Delevaryadress Destiontion) : base(Trackingcode, Description, Weight, Delevaryfee, Destiontion)
        {

        }

        public override decimal estimatedcost => throw new NotImplementedException();

        public override void printshipment()
        {
            Console.WriteLine($"trackingcode{trackingcode},description{description},wieght{weight},delevaryfee{delevaryfee},estimatedcost{estimatedcost}");
        }
        public string gettrackingstatus()
        {
            return $"shipment {trackingcode} is ready";
        }
        public decimal calculateinsurance()
        {
            return estimatedcost * 0.5m;
        }
    }
}
    


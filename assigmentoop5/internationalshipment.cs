using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigmentoop5
{
    internal class internationalshipment : Shipment, ITrackable, IInsurable
    {
        private string _destiontioncountry;
        private decimal _customfee;

        public internationalshipment(string destiontioncountry, decimal customfee, string Trackingcode, string Description, decimal Weight, decimal Delevaryfee, Delevaryadress Destiontion) : base(Trackingcode, Description, Weight, Delevaryfee, Destiontion)
        {
            Destiontioncountry = destiontioncountry;
            Customfee = customfee;
        }

        public string Destiontioncountry
        {
            get
            {
                return _destiontioncountry;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _destiontioncountry = value;
                }
            }
        }
        public decimal Customfee
        {
            get
            {
                return _customfee;
            }
            set
            {
                if (value >= 0)
                {
                    _customfee = value;
                }
            }
        }
        public override decimal estimatedcost
        {
            get
            {
                return delevaryfee + (weight * 5) + Customfee;
            }
        }
        public override void printshipment()
        {
            Console.WriteLine($"tracking:{trackingcode},description{description},weight{weight},delevaryfee{delevaryfee},estimatedcost{estimatedcost},destinationcountry{Destiontioncountry},customfee{Customfee}");
        }
        public virtual void genatrecustomreports()
        {

        }
        public string gettrackingstatus()
        {
            return $"shipment {trackingcode} been dlevered";
        }
        public decimal calculateinsurance()
        {
            return estimatedcost * 0.012m;
        }


    }
}
    


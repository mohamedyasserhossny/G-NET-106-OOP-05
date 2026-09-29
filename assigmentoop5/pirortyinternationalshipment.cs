using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace assigmentoop5
{
    internal class pirortyinternationalshipment : internationalshipment
    {
        public pirortyinternationalshipment(string destiontioncountry, decimal customfee, string Trackingcode, string Description, decimal Weight, decimal Delevaryfee, Delevaryadress Destiontion) : base(destiontioncountry, customfee, Trackingcode, Description, Weight, Delevaryfee, Destiontion)
        {
        }
        public sealed override void genatrecustomreports()
        {
            Console.WriteLine("Priority Customs Report");
            Console.WriteLine("Destination Country: " + Destiontioncountry);
            Console.WriteLine("Customs Fee: " + Customfee);
        }
    }
}
    


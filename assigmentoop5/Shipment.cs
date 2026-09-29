using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigmentoop5
{
    internal abstract class Shipment
    {
        public static int totalshipmentscreated = 0;
        private string _trackingcode;
        private string _description;
        private decimal _weight;
        private decimal _delevaryfee;
        public Delevaryadress destination { set; get; }
        
        public string trackingcode
        {
            get
            {
                return _trackingcode;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _trackingcode = value;
                }
            }
        }
        public string description
        {
            get
            {
                return _description;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _description = value;
                }
            }

        }
        public decimal weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
            }
        }
        public decimal delevaryfee
        {
            get
            {
                return _delevaryfee;
            }
            private set
            {
                if (value > 0)
                {
                    _delevaryfee = value;
                }
            }
        }
        public abstract decimal estimatedcost { get; }

        public Shipment(string Trackingcode)
        {
            totalshipmentscreated++;
            trackingcode = Trackingcode;
            description = "unkown";
            weight = 1;
            delevaryfee = 50;
            destination = new Delevaryadress("unkown", "unkown", 0);


        }
        static Shipment()
        {
            totalshipmentscreated = 0;
            Console.WriteLine("static intialized has happened");
        }
        public static int gettotalshipmentcreated() {
            return totalshipmentscreated;
        }
        

        

        public Shipment(string Trackingcode, string Description, decimal Weight, decimal Delevaryfee, Delevaryadress Destiontion)
        {
            totalshipmentscreated++;
            trackingcode = Trackingcode;
            description = Description;
            weight = Weight;
            delevaryfee = Delevaryfee;
            destination = Destiontion;
        }
        public void updatenewfee(decimal newfee)
        {
            if (newfee > 0)
            {


                delevaryfee = newfee;
            }

        }
        public abstract void printshipment();

        public void upadteweight(decimal newweight)
        {
            weight = newweight;
        }
        public void upadteweight(decimal newweight, decimal peckingweight)
        {
            weight = newweight + peckingweight;
        }
        public Shipment shalowcopy()
        {
            return (Shipment)MemberwiseClone();
        }
        public Shipment deepcopy()
        {
            Shipment shipment = (Shipment)MemberwiseClone();
            shipment.destination = new Delevaryadress(destination.city, destination.street, destination.buldingnumber);
            return shipment;
        }



    }
}
    


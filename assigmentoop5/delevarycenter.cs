using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigmentoop5
{
    internal class delevarycenter
    {
        public string centername { get; set; }
        public driver driver { set; get; }
        private Shipment[] shipments;
        public delevarycenter()
        {
            shipments = new Shipment[20];
        }
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                {
                    return shipments[index];
                }
                return null;

            }
            set
            {
                if (index >= 0 && index < shipments.Length)
                    shipments[index] = value;
            }
        }
        public Shipment this[string trackingcode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i] != null && shipments[i].trackingcode == trackingcode)
                    {
                        return shipments[i];
                    }
                }
                return default;
            }
        }
        public bool addshipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }

            }
            return false;
        }
        public bool removeshipment(string trackingcode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null && shipments[i].trackingcode == trackingcode)
                {
                    shipments[i] = null;
                    return true;
                }

            }
            return false;
        }
        public void printallshipments()
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null)
                {
                    shipments[i].printshipment();
                }
            }
        }
        public void printtrackingstatus()
        {
            foreach (Shipment shipment in shipments)
            {
                if (shipment != null && shipment is ITrackable trackable)
                {
                    Console.WriteLine(trackable.gettrackingstatus);
                }
            }
        }
        public void printinsurance()
        {
            foreach (Shipment shipment in shipments)
            {
                if (shipment != null && shipment is IInsurable insurable)
                {
                    Console.WriteLine(insurable.calculateinsurance);
                }
            }
        }

    }
}
    


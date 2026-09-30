using assigmentoop5;

namespace assigmentoop5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1
            //a) there are two refrence arrow on one object
            //b)no two refrence arroe to the same object ,no new object created
            //c)copying by refrence no new object created , copyng by object new object created 
            #endregion
            driver driver = new driver("ahmed mahmoud");
            delevarycenter delvarycenter = new delevarycenter();
            Console.WriteLine("enter the center name");
            delvarycenter.centername = Console.ReadLine();


            Console.WriteLine("enter tarckingcode");
            string trackingcode = Console.ReadLine();
            Console.WriteLine("enter description");
            string description = Console.ReadLine();
            Console.WriteLine("enter the weight");
            decimal weight = decimal.Parse(Console.ReadLine());
            Console.WriteLine("enter delevary fee");
            decimal delevaryfee = decimal.Parse(Console.ReadLine());
            Console.WriteLine("enter city");
            string city = Console.ReadLine();
            Console.WriteLine("enter the street");
            string street = Console.ReadLine();
            Console.WriteLine("enter the bulding number");
            int buldingnumber = int.Parse(Console.ReadLine());

            Delevaryadress destiontion = new Delevaryadress(city, street, buldingnumber);
            //Shipment shipment = new Shipment(trackingcode, description, weight, delevaryfee, destiontion);
            //bool aded = delvarycenter.addshipment(shipment);
            //if (aded)
            //{
            //    Console.WriteLine("succefull");
            //}
            //else
            //{
            //    Console.WriteLine("failed");
            //}
            standeredshipment standeredshipment = new standeredshipment(trackingcode, description, weight, delevaryfee, destiontion);
            bool aded = delvarycenter.addshipment(standeredshipment);
            if (aded)
            {
                Console.WriteLine("succefull");
            }
            else
            {
                Console.WriteLine("failed");
            }
            #region practical 1
            Shipment shipment1 = standeredshipment;
            Shipment shipment2 = shipment1;
            Console.WriteLine(shipment1.trackingcode);
            Console.WriteLine(shipment2.trackingcode);
            Console.WriteLine(ReferenceEquals(shipment1, shipment2));
            #endregion
            #region practical part 2
            Shipment shallow = shipment1.shalowcopy();
            Console.WriteLine(shipment1.destination.city);
            Console.WriteLine(shallow.destination.city);
            Console.WriteLine(ReferenceEquals(shipment1.destination, shallow.destination));
            shallow.destination.city = "giza";
            Console.WriteLine(shipment1.destination.city);
            Console.WriteLine(shallow.destination.city);
            Shipment deepcopy = shipment1.deepcopy();
            Console.WriteLine(ReferenceEquals(shipment1.destination, shallow.destination));
            deepcopy.destination.city = "assuit";
            Console.WriteLine(shipment1.destination.city);
            Console.WriteLine(shallow.destination.city);
            Console.WriteLine(ReferenceEquals(shipment1.destination, shallow.destination)); 
            #endregion


            Console.WriteLine("enter express trackingcode");
            string expresstrackingcode = Console.ReadLine();

            Console.WriteLine("enter express description");
            string expressdescription = Console.ReadLine();

            Console.WriteLine("enter express weight");
            decimal expressweight = decimal.Parse(Console.ReadLine());

            Console.WriteLine("enter express delevary fee");
            decimal expressdelevaryfee = decimal.Parse(Console.ReadLine());

            Console.WriteLine("enter express city");
            string expresscity = Console.ReadLine();

            Console.WriteLine("enter express street");
            string expressstreet = Console.ReadLine();

            Console.WriteLine("enter express bulding number");
            int expressbuldingnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("enter extrafee");
            decimal extrafee = decimal.Parse(Console.ReadLine());
            Delevaryadress expressdestion = new Delevaryadress(expresscity, expressstreet, expressbuldingnumber);
            expressshipment expressshipment = new expressshipment(extrafee, expresstrackingcode, expressdescription, expressweight, expressdelevaryfee, expressdestion);
            bool addexpress = delvarycenter.addshipment(expressshipment);
            if (addexpress)
            {
                Console.WriteLine("succefull");
            }
            else
            {
                Console.WriteLine("failed");
            }
            Console.WriteLine("enter international trackingcode");
            string internationaltrackingcode = Console.ReadLine();

            Console.WriteLine("enter international description");
            string internationaldescription = Console.ReadLine();

            Console.WriteLine("enter international weight");
            decimal internationalweight = decimal.Parse(Console.ReadLine());

            Console.WriteLine("enter international delevary fee");
            decimal internationaldelevaryfee = decimal.Parse(Console.ReadLine());

            Console.WriteLine("enter international city");
            string internationalcity = Console.ReadLine();

            Console.WriteLine("enter international street");
            string internationalstreet = Console.ReadLine();

            Console.WriteLine("enter international bulding number");
            int internationalbuldingnumber = int.Parse(Console.ReadLine());


            Console.WriteLine("enter your destion country");
            string destioncountry = Console.ReadLine();
            Console.WriteLine("enter customfee");
            decimal customfee = decimal.Parse(Console.ReadLine());
            Delevaryadress internationaldestiontion = new Delevaryadress(internationalcity, internationalstreet, internationalbuldingnumber);

            internationalshipment internationalshipment = new internationalshipment(destioncountry, customfee, internationaltrackingcode, internationaldescription, internationalweight, internationaldelevaryfee, internationaldestiontion);
            bool intranationaladd = delvarycenter.addshipment(internationalshipment);
            if (intranationaladd)
            {
                Console.WriteLine("succefull");
            }
            else
            {
                Console.WriteLine("failed");
            }
            delvarycenter.printallshipments();
            Console.WriteLine("tracking status");
            delvarycenter.printtrackingstatus();
            Console.WriteLine("insurance");
            delvarycenter.printinsurance();
            Console.WriteLine("deleveryhelper");
            DeliveryHelper.printshipmentdetails(expressshipment);
            DeliveryHelper.printshipmentdetails(standeredshipment);
            DeliveryHelper.printshipmentdetails(internationalshipment);
            ITrackable[] trackable ={
                standeredshipment,
                    expressshipment,
                    internationalshipment




            };
            foreach (ITrackable trackable1 in trackable)
            {
                Console.WriteLine(trackable1.gettrackingstatus);
            }
            IInsurable[] insurables =
            {
                 standeredshipment,
                    expressshipment,
                    internationalshipment

            };
            foreach (IInsurable insurable in insurables)
            {
                Console.WriteLine(insurable.calculateinsurance);
            }



            Console.WriteLine("enter tracking code for search");
            string searchcode = Console.ReadLine();
            Shipment foundshipment = delvarycenter[searchcode];
            if (foundshipment != null)
            {
                foundshipment.printshipment();
            }
            else
            {
                Console.WriteLine("not found ");
            }
            Console.WriteLine("enter trackingcode to remove");
            string removecode = Console.ReadLine();
            bool removed = delvarycenter.removeshipment(removecode);
            if (removed)
            {
                Console.WriteLine("succees");
            }
            else
            {
                Console.WriteLine("failed");
            }
            delvarycenter.printallshipments();
            #region paractical 6
            Console.WriteLine(Shipment.gettotalshipmentcreated());
            #endregion
            #region parctical 7
            deleveryutilise.printseprator();
            deleveryutilise.printsystemtitle();
            #endregion
            #region parctical 8
            Console.WriteLine(expressshipment.getsummary());
            Console.WriteLine(internationalshipment.getsummary());
            Console.WriteLine(standeredshipment.getsummary());
            Console.WriteLine(expressshipment.isdeleverd());
            Console.WriteLine(internationalshipment.isdeleverd());
            Console.WriteLine(standeredshipment.isdeleverd()); 
            #endregion
        }
    }
}
        
        #region question 2

        //a)a new object but the refrence type object refer to the same object
        //b) new object in all
        //c) stil refer to the same object 
        //d)refer to new object 


        #endregion
        #region qustion 3
        //a) ststic filed filed to the hall class ,instant filed to own object
        //b)static method follow the class such as empolyee.pay() not emp 1.pay() , no canot (لازم تكون ستاتيك)
        // c) static constructor is a counstructor called once at all life time of app , excuted first thing when run
        //d) class that canot creat object from 
        #endregion
        #region question 4
        //a) method that accept you to add other method to class have been created
        //b)this
        //c) in static class
        //d)no
        #endregion
        #region question 5
        //a) split class into two clases with the same name in the same file or diffrent files
        //b) عشان ممكن اتنين يشتغلو علي نفس الكلاس واحد مثلا يعمل ال ميثود و واجد يعمل الفيلد
        //c)ممكن نعرفها في ملف و نعمل ال بادي بتعها في ملف تاني 
        //d)its deleted in compile time
        #endregion
        
using System;
using System.Collections.Generic;

namespace TaxiManagement
{
    class Program
    {
        private static UserUI ui;
        
        

        static void Main(string[] args)
        {
            RankManager rm = new RankManager();
            TaxiManager txm = new TaxiManager();
            TransactionManager trm = new TransactionManager();
            ui = new UserUI(rm, txm, trm);
            
            DisplayMenu();
            int input = ReadInteger("select your use case using numbers 1-6 or 7-8 if you wish to exit");
            while (input == -1 || input >= 8 && input <= 1) { Console.Write("Invalid input ::\nmake sure to ");
                input = ReadInteger("select your use case using numbers 1-6 or 7-8 if you wish to exit");
            }
            while (input != 8 )
            {
                switch (input)
                {
                    case 1:
                        
                        TaxiJoinsRank();
                            break;
                    case 2:
                        TaxiLeavesRank();
                        break;
                    case 3:
                        TaxiDropsFare();
                        break;
                    case 4:
                        ViewFinancialReport();
                        break;
                    case 5:
                        ViewTransactionLog();
                        break;
                    case 6:
                        ViewTaxiLocations();
                        break;
                    case 7:
                        Console.WriteLine("sadness");
                        return;


                }
                DisplayMenu();
                input = ReadInteger("select your use case using numbers 1-6 or 7-8 if you wish to exit");
            }

        }
        private static void DisplayMenu()
        {
            Console.WriteLine("\n1. Taxi joins rank");
            Console.WriteLine("\n2. Taxi leaves rank");
            Console.WriteLine("\n3. Taxi drops fare");
            Console.WriteLine("\n4. View financial report");
            Console.WriteLine("\n5. View transaction log");
            Console.WriteLine("\n6. View taxi locations\n");
        }
        
        private static void DisplayResults(List<string> results)
        {
            foreach (string s in results)
            { Console.WriteLine(s); }



        }
        private static int ReadInteger(string prompt)
        {
            try
            {
                Console.Write(prompt + ": > ");
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                return -1;
            }
        }
        private static double ReadDouble(string prompt)
        {
            try
            {
                Console.Write(prompt + ": > ");
                return Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public static string Readstring(string prompt)
        {
            try
            {
                Console.Write(prompt + ": > ");
                return Convert.ToString(Console.ReadLine());
            }
            catch (Exception)
            {
                return "beep beep richie";
            }
        }
        private static void TaxiDropsFare()
        {
            bool eztras = true;
            string extra = Readstring("\nWould you like to complete further transactions in this type, Yes or No").ToLower();
            while (extra == "beep beep richie" || extra != "yes" && extra != "no")
            {
                Console.WriteLine("Invalid input try again. Yes or no answers only. \n Be sure you have the correct spelling");
                extra = Readstring("\nWould you like to complete further transactions in this type, Yes or No").ToLower();
            }

            if (extra == "yes")
            { eztras = true; }
            else
            {
                int taxinum = ReadInteger("Input the taxi number");
                while (taxinum == -1)
                {
                    Console.WriteLine("\nInvalid number for taxi input try again. Positive integers only");
                    taxinum = ReadInteger("\nInput the taxi number");
                }

                string priCePaid = Readstring("Has the price been paid enter True or False").ToLower();
                while (priCePaid == "beep beep richie" || priCePaid != "true" && priCePaid != "false")
                {
                    Console.WriteLine("\nInvalid input try again. True or False answer only. \n Be sure you have the correct spelling");
                    priCePaid = Readstring("\nHas the price been paid enter True or False\n").ToLower();
                    ;
                }
                bool pricepaid;
                if (priCePaid == "true") { pricepaid = true; }
                else { pricepaid = false; }
                List<string> TaxiDropsfare = ui.TaxiDropsFare(taxinum, pricepaid);
                DisplayResults(TaxiDropsfare); eztras = false;
            }


            while (eztras != false) { 
                //  int joined = 0;

                int taxinum = ReadInteger("Input the taxi number");
            while (taxinum == -1)
            {
                Console.WriteLine("\nInvalid number for taxi input try again. Positive integers only");
                taxinum = ReadInteger("\nInput the taxi number");
            }

            string priCePaid = Readstring("Has the price been paid enter True or False").ToLower();
            while (priCePaid == "beep beep richie" || priCePaid != "true" && priCePaid != "false")
            {
                Console.WriteLine("\nInvalid input try again. True or False answer only. \n Be sure you have the correct spelling");
                priCePaid = Readstring("\nHas the price been paid enter True or False\n").ToLower();
                ;
            }
            bool pricepaid;
            if (priCePaid == "true") { pricepaid = true; }
            else { pricepaid = false; }
                List<string> TaxiDropsfare = ui.TaxiDropsFare(taxinum, pricepaid);
                DisplayResults(TaxiDropsfare);
                extra = Readstring("\nWould you like to complete further transactions, Yes or No").ToLower();
            while (extra == "beep beep richie" || extra != "yes" && extra != "no")
            {
                Console.WriteLine("Invalid input try again. Yes or no answers only. \n Be sure you have the correct spelling");
                extra = Readstring("\nWould you like to complete further transactions, Yes or No").ToLower();
            }

            if (extra == "yes")
            { eztras = true; }
            else { eztras = false; }
            
        }
            
//joined++;
}
        private static void TaxiJoinsRank() { 
        {//string extra = Readstring("Would you like to see join rank history, Yes for no ,No for yes").ToLower();

            //while (extra == "beep beep richie" || extra != "yes" && extra != "no")
            //{
            //    Console.WriteLine("Invalid input try again. Yes or no answers only. \n Be sure you have the correct spelling");
            //    extra = Readstring("Would you like to see join rank history, Yes for no ,No for yes").ToLower();

            //}
            //bool eztras;
            //if (extra == "true") 
            //{ eztras = true; }
            //else { eztras = false; }
            //if (eztras = false) {
            //int joined = 0;
            bool eztras = true;
               
                    string extra = Readstring("\nWould you like to complete further transactions in this type, Yes or No").ToLower();
                while (extra == "beep beep richie" || extra != "yes" && extra != "no")
                {
                    Console.WriteLine("Invalid input try again. Yes or no answers only. \n Be sure you have the correct spelling");
                    extra = Readstring("\nWould you like to complete further transactions in this type, Yes or No").ToLower();
                }

                if (extra == "yes")
                { eztras = true; }
                else {
                    int taxinum = ReadInteger("\nInput the taxi number");
                    while (taxinum == -1)
                    {
                        Console.WriteLine("Invalid number for taxi input try again. Positive integers only");
                        taxinum = ReadInteger("\nInput the taxi Number");
                    }
                    int rankid = ReadInteger("\nInput the rank number");
                    while (rankid == -1)
                    {
                        Console.WriteLine("Invalid number for rank id input try again. Positive integers only");
                        rankid = ReadInteger("\nInput the rank number\n");
                    }
                    List<string> Taxijoins = ui.TaxiJoinsRank(taxinum, rankid);
                    DisplayResults(Taxijoins);
                    eztras = false;
                }
                while (eztras != false)
            {
                int taxinum = ReadInteger("\nInput the taxi number");
                while (taxinum == -1)
                {
                    Console.WriteLine("Invalid number for taxi input try again. Positive integers only");
                    taxinum = ReadInteger("\nInput the taxi Number");
                }
                int rankid = ReadInteger("\nInput the rank number");
                while (rankid == -1)
                {
                    Console.WriteLine("Invalid number for rank id input try again. Positive integers only");
                    rankid = ReadInteger("\nInput the rank number\n");
                }
                    List<string> Taxijoins = ui.TaxiJoinsRank(taxinum, rankid);
                    DisplayResults(Taxijoins);
                    extra = Readstring("\nWould you like to complete further transactions, Yes or No").ToLower();
                while (extra == "beep beep richie" || extra != "yes" && extra != "no")
                {
                    Console.WriteLine("Invalid input try again. Yes or no answers only. \n Be sure you have the correct spelling");
                    extra = Readstring("\nWould you like to complete further transactions, Yes or No").ToLower();
                }
                
                if (extra == "yes")
                { eztras = true; }
                else { eztras = false; }

                
            }
        }
    // Console.WriteLine(ui.TaxiJoinsRank(taxinum, rankid)[0]);
//joined++;
            //string extra = Readstring("Would you like to see join rank history, Yes for no ,No for yes").ToLower();
                
            //while (extra == "beep beep richie" || extra != "yes" && extra != "no")
            //{
            //    Console.WriteLine("Invalid input try again. Yes or no answers only. \n Be sure you have the correct spelling");
            //    extra = Readstring("Would you like to see join rank history, Yes for no ,No for yes").ToLower();
               
            //}
            //bool eztras;
            //if (extra == "true") 
            //{ eztras = true; }
            //else { eztras = false; }
            //if (eztras = false) {
            //    foreach (string s in ui.TaxiJoinsRank())
            //    { Console.WriteLine(s); }
            //}



        }
        private static void TaxiLeavesRank()
        {
            //int joined = 0;
            bool eztras = true;
            string extra = Readstring("\nWould you like to complete further transactions in this type, Yes or No").ToLower();
            while (extra == "beep beep richie" || extra != "yes" && extra != "no")
            {
                Console.WriteLine("Invalid input try again. Yes or no answers only. \n Be sure you have the correct spelling");
                extra = Readstring("\nWould you like to complete further transactions in this type, Yes or No").ToLower();
            }

            if (extra == "yes")
            { eztras = true; }
            else
            {
                int rankid = ReadInteger("\nInput the rank number");
                while (rankid == -1)
                {
                    Console.WriteLine("\nInvalid number for rank id input try again. Positive integers only");
                    rankid = ReadInteger("\nInput the rank number");
                }
                string destination = Readstring("input taxi destination");
                while (destination == "beep beep richie")
                {
                    Console.WriteLine("\nInvalid input try again. ");
                    destination = Readstring("\ninput taxi destination");
                }


                double agreedPrice = ReadDouble("\nInput the agreed upon price.");
                while (agreedPrice == -1)
                {
                    Console.WriteLine("\nInvalid number for taxi input try again. numbers only");
                    agreedPrice = ReadDouble("\nInput the agreed upon price\n.");
                }
                List<string> TaxiLeaves = ui.TaxiLeavesRank(rankid, destination, agreedPrice);
                DisplayResults(TaxiLeaves);
                eztras = false;
            }
            while (eztras != false)
            {

                int rankid = ReadInteger("\nInput the rank number");
                while (rankid == -1)
                {
                    Console.WriteLine("\nInvalid number for rank id input try again. Positive integers only");
                    rankid = ReadInteger("\nInput the rank number");
                }
                string destination = Readstring("input taxi destination");
                while (destination == "beep beep richie")
                {
                    Console.WriteLine("\nInvalid input try again. ");
                    destination = Readstring("\ninput taxi destination");
                }


                double agreedPrice = ReadInteger("\nInput the agreed upon price.");
                while (agreedPrice == -1)
                {
                    Console.WriteLine("\nInvalid number for taxi input try again. numbers only");
                    agreedPrice = ReadDouble("\nInput the agreed upon price\n.");
                }
                List<string> TaxiLeaves = ui.TaxiLeavesRank(rankid, destination, agreedPrice);
                DisplayResults(TaxiLeaves);
                extra = Readstring("\nWould you like to complete further transactions, Yes or No").ToLower();
                while (extra == "beep beep richie" || extra != "yes" && extra != "no")
                {
                    Console.WriteLine("Invalid input try again. Yes or no answers only. \n Be sure you have the correct spelling");
                    extra = Readstring("Would you like to complete further transactions, Yes or No").ToLower();
                }

                if (extra == "yes")
                { eztras = true; }
                else { eztras = false; }
                
            }
}
        //woopty doo
        private static void ViewFinancialReport()
        {
    List<string> finances =ui.ViewFinancialReport();
    DisplayResults(finances);

   // foreach (string s in ui.ViewFinancialReport())
   // { Console.WriteLine(s); }







}
        private static void ViewTaxiLocations()
        { List<string> locations = ui.ViewTaxiLocations();
    DisplayResults(locations);
    //foreach (string s in ui.ViewTaxiLocations())
    //{ Console.WriteLine(s); }
}
        private static void ViewTransactionLog()
        { List<string> transactions = ui.ViewTransactionLog();
    DisplayResults(transactions);
            //foreach (string s in ui.ViewTransactionLog())
            //{ Console.WriteLine(s); }
}
        
    }
}

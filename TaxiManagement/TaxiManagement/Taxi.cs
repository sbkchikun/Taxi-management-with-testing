using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiManagement
{
    public class Taxi
        
    { 

        public Rank Rank
        {
            get { return rank; }
            set
            {
                if (value == null)
                { throw new Exception("Rank cannot be null"); }
                if (Destination.Length != 0) { throw new Exception("Cannot join rank if fare has not been dropped"); }
                else
                    rank = value;
                     Location= IN_RANK ; } 
            
        }
        public static string IN_RANK = "in rank";
        public static string ON_ROAD = "on the road";
        private Rank rank;
        private double totalMoneyPaid = 0.00;
        public double TotalMoneyPaid { get { return totalMoneyPaid; }set { TotalMoneyPaid = value; } }
        public void AddFare(string destination,double agreedPrice ) 
        { Destination = destination;
            CurrentFare = agreedPrice;
            Location = ON_ROAD;
            rank = null;
        }

        public void DropFare(bool priceWasPaid) 
        {if
           (priceWasPaid == true)
            totalMoneyPaid = totalMoneyPaid + currentFare;
                currentFare = 0.00;
            destination = "";


            if (priceWasPaid == false)
                
            destination = "";



        }
        public static string name;

        public int Number { get { return number; } set {number=value; } }
        public double CurrentFare { get { return currentFare; } set {currentFare=value; } }
        public string Destination { get { return destination; } set{destination=value;} }
        public string Location { get { return location; }set { location = value; } }
        private int number;

        public Taxi(int number)
        {
            this.number = number;
        }
        private double currentFare;


        private string destination = "";
        private string location = (ON_ROAD);
        

        





    }   

}

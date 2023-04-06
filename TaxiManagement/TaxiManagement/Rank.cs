using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiManagement
{

    public class Rank


    {
        private int id;
        private int numberOfTaxiSpaces;
        private List<Taxi> Taxispace = new List<Taxi>();
        public int Id{ get { return id; } set { id = value; } }
        public Rank(int rankId, int numberOfTaxiSpacs) 
        {
            Id = rankId;
            numberOfTaxiSpaces = numberOfTaxiSpacs;
            Taxispace = new List<Taxi>(numberOfTaxiSpaces);
            
        
        
        }
        public Taxi FrontTaxiTakesFare(string destination, double agreedPrice) {
            if (Taxispace.Count != 0)
            {
                List<Taxi> temp = new List<Taxi>();
                Taxi temptaxi = Taxispace[0];
                temptaxi.AddFare(destination, agreedPrice);
                temp.Add(Taxispace[0]);
                numberOfTaxiSpaces++;
                Taxispace.RemoveAt(0);
                return temp[0];
            }
            else
             return null;

        }
        public bool AddTaxi(Taxi t)
        {
            //int tn = t.Number;
            //int duplica= 0;

            //foreach (Taxi c in Taxispace) { if (c.Number == tn)
            //    duplica++;}  
            if (numberOfTaxiSpaces >0 && t.Destination.Length == 0)
            {
                Taxispace.Add(t);

                t.Rank = this;
                numberOfTaxiSpaces--;
                return true;
            }
            else return false;
          
            
                    }



    }
}

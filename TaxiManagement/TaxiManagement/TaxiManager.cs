using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiManagement
{
    public class TaxiManager
    {
        private SortedDictionary<int, Taxi> taxis = new SortedDictionary<int, Taxi>();
        public Taxi CreateTaxi(int taxiNum)
        {
            bool foundkey = taxis.ContainsKey(taxiNum);
            if (foundkey == true)
            { return FindTaxi(taxiNum); }
            else
            {
                Taxi temptaxi = new Taxi(taxiNum);
                taxis.Add(taxiNum, temptaxi);
                return temptaxi;
            }


        }
        public SortedDictionary<int, Taxi> GetAllTaxis() { return taxis; }
        
        public Taxi FindTaxi(int taxiNum) {
            bool foundkey = taxis.ContainsKey(taxiNum);
            if (foundkey == true)
            {
                return taxis[taxiNum];
            }
            else
            { return null; }
                
        }
    }
}

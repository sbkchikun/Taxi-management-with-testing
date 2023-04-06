using System;
using System.Collections.Generic;
using System.Text;
namespace TaxiManagement
{
    public class RankManager
    {
        private Dictionary<int, Rank> ranks = new Dictionary<int, Rank>();
        public RankManager()
        {//creates the ranks for the tests
            Rank Numerouno = new Rank(1, 5);
            Rank Numerodos = new Rank(2, 2);
            Rank Numerotres = new Rank(3, 4);
            ranks.Add(1, Numerouno);
            ranks.Add(2, Numerodos);
            ranks.Add(3, Numerotres);
        }
        public Rank FindRank(int rankid)
        {
            bool foundkey = ranks.ContainsKey(rankid);
            if (foundkey == true)
            {
                return ranks[rankid];
            }
            else
            { return null; }

        }

        public bool AddTaxiToRank(Taxi t, int rankid)
        {
            if (ranks.ContainsKey(rankid) == false)
            {
                return false;
            }

            if (t.Rank != null)
            {
                return false;
            }


            return ranks[rankid].AddTaxi(t);
            //    if (ranks.ContainsKey(rankid) == true)
            //{
            //    Rank r = ranks[rankid];
            //    //Rank r1 = ranks[1];
            //    //Rank r2 = ranks[2];
            //    //Rank r3 = ranks[3];
               
            //    if (r.AddTaxi(t) == true)
            //    {
            //        if (r1.AddTaxi(t) == true && r2.AddTaxi(t) == true && r3.AddTaxi(t) == true)
            //        {
            //            if (r.AddTaxi(t) == true)
            //            {
            //                r.AddTaxi(t);
            //                return true;
            //            }
            //            else { return false; }
            //        }
            //        else
            //            return false;
                    
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            //else { return false; }

        }
        public Taxi FrontTaxiInRankTakesFare(int rankId, string destination, double agreedPrice)
        {
            Rank r = FindRank(rankId);
            if (r != null)
            {
                Taxi t = r.FrontTaxiTakesFare(destination, agreedPrice);
                return t;
            }
            return null;
        }
    }
}
    


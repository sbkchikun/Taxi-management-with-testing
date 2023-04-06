using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiManagement
{
    public class UserUI
    {
        private RankManager rankMgr;
        private TransactionManager transactionMgr;
        private TaxiManager taxiMgr;

        public UserUI(RankManager rkMgr, TaxiManager txMgr, TransactionManager trMgr)
        {//initialise values
            this.rankMgr = rkMgr;
            this.transactionMgr = trMgr;
            this.taxiMgr = txMgr;
        }

        public List<string> TaxiDropsFare(int taxiNum, bool pricePaid)
        {
            Taxi t = taxiMgr.FindTaxi(taxiNum);
            if (t != null && t.Location == "on the road" && t.Destination.Length != 0)
            {
                if (pricePaid == true)
                {
                    transactionMgr.RecordDrop(taxiNum, pricePaid);
                    List<string> lsuccess = new List<string>();
                    lsuccess.Add("Taxi " + taxiNum + " has dropped its fare and the price was paid.");
                    t.DropFare(true);
                    return lsuccess;

                }
                else
                {
                    transactionMgr.RecordDrop(taxiNum, pricePaid);
                    List<string> lsuccess = new List<string>();
                    lsuccess.Add("Taxi " + taxiNum + " has dropped its fare and the price was not paid.");
                    t.DropFare(false);
                    return lsuccess;

                }
            }
            else
            {
                List<string> lsuccess = new List<string>();
                lsuccess.Add("Taxi " + taxiNum + " has not dropped its fare.");

                return lsuccess;
            }

        }
        public List<string> TaxiJoinsRank(int taxiNum, int rankId)
        {
            
            Taxi taxi = taxiMgr.CreateTaxi(taxiNum);

            if (rankMgr.AddTaxiToRank(taxi, rankId) == true)
            {
                rankMgr.AddTaxiToRank(taxi, rankId);
                transactionMgr.RecordJoin(taxiNum, rankId);
                
                List<string> lsuccess = new List<string>();
                lsuccess.Add("Taxi " + taxiNum + " has joined rank " + rankId + ".");

                return lsuccess;
            }
            else
            {

                List<string> lsuccess = new List<string>();
                lsuccess.Add("Taxi " + taxiNum + " has not joined rank " + rankId + ".");

                return lsuccess;

            }
        }

        public List<string> TaxiLeavesRank(int rankId, string destination, double agreedprice)
        {
            Taxi t = rankMgr.FrontTaxiInRankTakesFare(rankId, destination, agreedprice);

            if (t != null)
            {
                transactionMgr.RecordLeave(rankId, t);
                int taxinum = t.Number;
                List<string> lsuccess = new List<string>();
                lsuccess.Add("Taxi " + taxinum + " has left rank " + rankId + " to take a fare to " + destination + " for £" + agreedprice + ".");
                
                return lsuccess;

            }
            else
            {


                List<string> lsuccess = new List<string>();
                lsuccess.Add("Taxi has not left rank " + rankId + ".");

                return lsuccess;
            }




        }
        public List<string> ViewTaxiLocations()
        {
            List<string> Lsuccess = new List<string>();
            Lsuccess.Add("Taxi locations");
            Lsuccess.Add("==============");
            SortedDictionary<int, Taxi> taxis = taxiMgr.GetAllTaxis();
            
            if (taxis.Count == 0)
            {


                Lsuccess.Add("No taxis");
                return Lsuccess;
            }
            else
            {
                foreach (Taxi t in taxis.Values)
                {
                    Rank r = t.Rank;
                    if (r != null)
                    {


                        Lsuccess.Add("Taxi " + t.Number + " is in rank " + r.Id);
                    }
                    else if (t.Location == Taxi.ON_ROAD)
                    {
                        {
                            if (t.Destination.Length != 0)
                            {

                                Lsuccess.Add("Taxi " + t.Number + " is on the road to " + t.Destination);
                            }
                            else if (t.Destination.Length == 0)
                            {

                                Lsuccess.Add("Taxi " + t.Number + " is on the road");
                            }
                        }


                    }

                }

                return Lsuccess;
            }

        }
        public List<string> ViewFinancialReport()
        {
            SortedDictionary<int, Taxi> taxis = taxiMgr.GetAllTaxis();
            double grandtotal = 0.00;
            List<string> financialreport = new List<string>();
            financialreport.Add("Financial report");
            financialreport.Add("================");
            if (taxis.Count == 0)
            {

                
                financialreport.Add("No taxis, so no money taken");
                return financialreport;
            }
            else
            {
                foreach (Taxi t in taxiMgr.GetAllTaxis().Values)

                {

                    financialreport.Add(String.Format("Taxi "+t.Number+ "      {0,0:0.00}" , t.TotalMoneyPaid));
                    //financialreport.Add("           ======");
                    grandtotal = grandtotal + t.TotalMoneyPaid;
                }
                financialreport.Add("           ======");
                financialreport.Add(String.Format("Total:       {0,0:0.00}", grandtotal));
                financialreport.Add("           ======");
                return financialreport;
            }
        }
        public List<string> ViewTransactionLog() 
        {
            
            List<string> Transactionloggg = new List<string>();
            
            Transaction t = new JoinTransaction(DateTime.Now,3,2);
            
            
            Transactionloggg.Add("Transaction report");
            Transactionloggg.Add("==================");
            
            


            if (transactionMgr.GetAllTransactions().Count==0)
            {
                
                

                Transactionloggg.Add("No transactions");
                return Transactionloggg ;

            }
            else{
                foreach (Transaction tra in transactionMgr.GetAllTransactions())
                {
                    tra.GetType();
                    Transactionloggg.Add(tra.ToString());
                 }
            return Transactionloggg;}
        }
    }
}






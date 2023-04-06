using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiManagement
{
    public class TransactionManager
    {
        List<Transaction> transactions = new List<Transaction>();
        public void RecordJoin(int taxiNum,int rankId) 
        { JoinTransaction recjoin = new JoinTransaction(DateTime.Now, taxiNum, rankId);
            transactions.Add(recjoin);
        }
        public List<Transaction> GetAllTransactions() { return transactions; }
        public void RecordDrop(int taxiNum, bool pricePaid)
        {
            DropTransaction recdrop = new DropTransaction(DateTime.Now, taxiNum,pricePaid );
            transactions.Add(recdrop);
            
        }
        
        public void RecordLeave( int rankId,Taxi t)
        {
            LeaveTransaction recLeave = new LeaveTransaction(DateTime.Now, rankId,t);
            transactions.Add(recLeave);
        }
        
    }
    
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiManagement
{
    public abstract class Transaction
    {
        public Transaction(string type, DateTime dt) 
        {
            this.TransactionType = type;
            this.TransactionDatetime = dt;
        }
        private DateTime transactionDatetime;
        private string transactionType;
        
        public DateTime TransactionDatetime { get { return transactionDatetime; } set{ transactionDatetime= value  ; }}
        public string TransactionType { get { return transactionType; } set {  transactionType= value ; } }
        public abstract override string ToString();
    }
    public class JoinTransaction : Transaction
    {
        private int taxiNum;
        private int rankId;
        
        public JoinTransaction(DateTime transactionDatetime, int num, int Id):base("Join", transactionDatetime)
        {
            taxiNum = num;
            rankId = Id;
            TransactionDatetime = transactionDatetime;
            TransactionType = "Join";
        }
        public override string ToString()
        { 
            return TransactionDatetime.ToString("dd/MM/yyyy HH:mm") + (" " + TransactionType + "      - Taxi " + taxiNum + " in rank " + rankId);
        }
    }
     public class DropTransaction : Transaction
    {
        private int taxiNum;
        private bool priceWasPaid;
        private string endtext;
        public DropTransaction(DateTime transactionDatetime, int num,bool PricewasPaid) : base("Drop fare", transactionDatetime)
        {
            taxiNum = num;
            priceWasPaid = PricewasPaid;
            if (priceWasPaid == true) { endtext = ", price was paid"; }
            else { endtext = ", price was not paid"; }
            TransactionDatetime = transactionDatetime;
            TransactionType = "Drop fare";
        }
        public override string ToString()
        {
            
               return TransactionDatetime.ToString("dd/MM/yyyy HH:mm") + (" " + TransactionType + " - Taxi " + taxiNum + endtext);
        }
    }
     public class LeaveTransaction : Transaction
     {
        private int taxiNum;
        private int rankId;
        private string destination;
        private double agreedPrice;
        public LeaveTransaction( DateTime transactionDatetime,int Id, Taxi t) : base("Leave", transactionDatetime)
        {//add check
            
            rankId = Id;
            TransactionDatetime = transactionDatetime;
            TransactionType = "Leave";
            taxiNum=t.Number;
            destination = t.Destination;
            agreedPrice = t.CurrentFare;
            
        }
        public override string ToString()
        {
            return TransactionDatetime.ToString("dd/MM/yyyy HH:mm") + (" " + TransactionType + "     - Taxi " + taxiNum + " from rank " + rankId+" to "+destination+" for £"+agreedPrice);
        }
    }
        
    }

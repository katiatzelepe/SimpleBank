using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBank
{
    public class Transaction
    {

        public DateTime datetime { get; set; }
        public decimal amount { get; set; }
        public string action { get; set; }
        public string actor { get; set; }

        //public Transaction ()
        //{

        //}

        public Transaction(DateTime datetime, decimal amount, string action, string actor)
        {
            this.datetime = datetime;
            this.amount = amount;
            this.action = action;
            this.actor = actor;
        }

        public override string ToString()
        {
            return $"\ndatetime= {datetime}\t amount= {amount}\t  action= {action}\t \nactor: {actor}";
        }
    }
}

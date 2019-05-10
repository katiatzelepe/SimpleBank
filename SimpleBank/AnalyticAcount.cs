using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace SimpleBank
{
    public class AnalyticAcount : Account
    {
        private readonly List<Transaction> transactions;

       // transactions = new List<Transaction>(); ** tha mporousa na to exw kai edw anti gia tin contructor**
      
        private const string fileName = @"C:\mydata\academy\transactions.json";
        public AnalyticAcount(Person owner) : base(owner) // contructor from Account
        {
            transactions = new List<Transaction>();
        }

        public override bool Deposit(decimal amount) //  override the methods from the father class Account
        {
            transactions.Add(new Transaction(DateTime.Now,
                amount, "deposit", Owner));
            return base.Deposit(amount);
        }

        public override bool WithDraw(decimal amount)
        {
            transactions.Add(new Transaction(DateTime.Now,
                amount, "WithDraw", Owner));
            return base.WithDraw(amount);
        }

        public void PrintTransaction()
        {
            foreach (Transaction t in transactions)
            {
                Console.WriteLine(t);
            }
        }

        public void SaveToFile(string fileName) //save to file : fileName
        {
            using (StreamWriter file =
            new StreamWriter(fileName))
            {
                foreach (Transaction t in transactions)
                {

                    file.WriteLine(t);

                }
            }

        }

      
        public void SaveToJson()

        {
            string json = JsonConvert.
                SerializeObject(transactions.ToArray());
            File.WriteAllText(fileName , json); // @ sets tha the strings that follows you dont use escape characters
        }

        public void LoadJson()
        {
            //List<Transaction> temptransactions;
            string data = File.ReadAllText(fileName);
            var tempTransactions = JsonConvert.
                DeserializeObject<List<Transaction>>(data); // Load from json file
            foreach (Transaction t in tempTransactions)
            {
                transactions.Add(t);

            }
            //transactions.Sort();
        }
    }
}

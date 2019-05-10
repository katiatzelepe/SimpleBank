using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(1, "Katerina", "Kavala");
            var account = new AnalyticAcount(person);
            account.LoadJson();
            //Console.WriteLine(account);
            //account.PrintTransaction();
            account.Deposit(1);
            ///trytryrt
            //account.Deposit(100);
            //account.Deposit(4000);
            account.WithDraw(2);
            //account.PrintTransaction();
            //account.SaveToFile("myFile.txt");
            account.SaveToJson();

            Console.ReadLine();
        }
    }
}

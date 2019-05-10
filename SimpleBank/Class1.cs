using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBank


{
    //public interface IPrintable
    //{
    //    void Print();
    //}
    public abstract class Account //: IPrintable
    {
        private Person _owner;
        private decimal _Balance; /// _name is for private
        public decimal Balance { get { return _Balance; } }

        public string Owner { get { return _owner.ToString(); } }
        public Account(Person owner)
        {
            _owner = owner;
            _Balance = 0;
        }

        public virtual bool WithDraw(decimal amount) 
        {

            _Balance -= amount;
            return true;
        }


        public virtual bool Deposit(decimal amount)
        {
            _Balance += amount;
             return true;
        }

        //public void Print()
        //{
        //    Console.WriteLine();
        //}
    }

    public class SimpleAccount : Account
    {
        public SimpleAccount(Person owner) : base(owner) // contructor from Account
        {
        }

        public override bool Deposit(decimal amount) //  override the methods from the father class Account
        {
            return base.Deposit(amount);
        }

        public override bool WithDraw(decimal amount)
        {
            return base.WithDraw(amount);
        }
    }

    


}

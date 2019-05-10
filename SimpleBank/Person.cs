using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBank

// POCO the simpliest thing 
{
    public class Person
    {
        private int _id;
        private string _name;
        private string _address;

        public Person() 
        {

        }

        public Person(int id, string name, string address)
        {
            this._id = id;
            this._name = name;
            this._address = address;
        }

        public override string ToString()
        {
            return $"id={_id}\t name= {_name}\t address={_address}\t";
        }
    }
}

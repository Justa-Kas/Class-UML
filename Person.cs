using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassUML
{
    class Person
    {
        //properties
        public String name { get; set; }
        public String address { get; set; }

        //constructor
        public Person(String name, String address)
        {
            this.name = name;
            this.address = address;
        }

        //methods
        public override string ToString()
        {
            return $"Person[name={name},address={address}]";
        }
    }
}

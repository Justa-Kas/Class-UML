using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassUML
{
    class Staff:Person
    {
        public String school { get; set; }
        public double pay { get; set; }

        public Staff(String name, String address, String school, double pay):base(name, address)
        {
            this.school = school;
            this.pay = pay;
        }

        
        public override string ToString()
        {
            return $"Staff[{base.ToString()},school={school},pay={pay}";
        }
    }
}

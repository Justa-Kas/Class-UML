using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassUML
{
    class Student:Person
    {
        //properties
        public String program { get; set; }
        public int year { get; set; }
        public double fee { get; set; }

        //constructor
        public Student(String name, String address, String program, int year, double fee):base(name, address)
        {
            this.program = program;
            this.year = year;
            this.fee = fee;
        }

        //method
        public override string ToString()
        {
            return $"Student[{base.ToString()},program={program},year={year},fee={fee}";
        }
    }
}

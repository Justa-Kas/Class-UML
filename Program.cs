using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassUML
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> schoolList = new List<Person> { };
            Person p1 = new Person("Bill", "345 St. Vega St");
            Staff p2 = new Staff("Peter Doss", "8123 Gregetta Blvd", "Griften International High School",48000);
            Staff p3 = new Staff("Joselyn Ross", "373 E Nuesos", "Griften International High School",52000);
            Student p4 = new Student("Joseph Stewart", "4848 Jimpelt St", "Computer Science", 2, 24000);
            Student p5 = new Student("Jilian Hawthorn", "888 New Vegas", "Chemical Engineering", 4, 22000);
            Student p6 = new Student("Grant Baker", "6253 Shelton Dr", "Business", 1, 34000);
            schoolList.Add(p1);
            schoolList.Add(p2);
            schoolList.Add(p3);
            schoolList.Add(p4);
            schoolList.Add(p5);
            schoolList.Add(p6);

            foreach(Person person in schoolList)
            {
                GetPerson(person);
            }

            
            Console.ReadKey();

        }

        static void GetPerson(Person person)
        {
            Console.WriteLine(person.ToString());
        }

       
    }
}

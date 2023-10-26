using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //!!!classların tek başına bir anlamı vardır ama interfacelerin tek başına bir anlamı yoktur.

    /*
     * interfacelerden yürü(inheritance mantığıyla kullanılabilir çünkü.)
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer
                {
                    FirstName = "Hasan"
                }, new Student
                {
                    FirstName = "Ayşenur"
                }, new Person
                {
                    FirstName = "Veysel"
                }
            };
            foreach (Person person in persons) 
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }


    class Customer:Person  //Customer'ın babası Person
    {
        public string City { get; set; }
    }
    class Student:Person  //Student'ın babası Person
    {
        public string Department { get; set; }
    }
}

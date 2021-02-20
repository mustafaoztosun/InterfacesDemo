using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer
                {
                    Firstname = "Mustafa"
                }, new Student
                {
                    Firstname = "Gözde"
                }, new Person
                {
                    Firstname = "İsmail"
                }
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.Firstname);
            }

            Console.ReadLine();
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
    }


    class Customer:Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }
}

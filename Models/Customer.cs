using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking
{
    public class Customer
    {
        public int hoursParked { get; set; }

        public string Registration { get; set; }
        public Customer(string registration,int hoursParked)
        {
            Console.WriteLine("I am the customer");
            Registration = registration;
            this.hoursParked = hoursParked;
        }

        public override string ToString()
        {
            return "I am the Customer()";
        }
    }
}

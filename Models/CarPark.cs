using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking
{
    public class CarPark
    {
        public List<Customer> listofCustomers = new List<Customer>();
        public CarPark()
        {
            Console.WriteLine("I am the carPark");
        }

        public override string ToString()
        {
            return "I am the CarPArk()";
        }

        public void CalculateCharges()
        {
            foreach(Customer customer in listofCustomers)
            {
                int calculatedCharge = carparkcharge(customer.hoursParked);
                Console.WriteLine($"Calculating charge for customer: cost is {calculatedCharge}");
            }
        }
    }
}

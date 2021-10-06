using oop_lesson_4_parking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking.Test
{
    public class Driver
    {
        public Driver()
        {
            Console.WriteLine("I am the code driver");
        }

        public void CreateObjects()
        {
            CarPark carpark = new CarPark();
            carpark.listofCustomers.Add(new Customer("a",2));
            carpark.listofCustomers.Add(new Customer("b",3));
            carpark.listofCustomers.Add(new Customer("c",4));
            carpark.listofCustomers.Add(new Customer("d",5));

            carpark.CalculateCharges();

            Customer customer = new Customer("e",8);
            CarParkCharges carparkcharge = new CarParkCharges();

            //Call the ToString methode

            Console.WriteLine(carpark.ToString());
            Console.WriteLine(customer.ToString());
            Console.WriteLine(carparkcharge.ToString());


        }
    }
}

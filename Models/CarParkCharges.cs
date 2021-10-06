using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking.Models
{
    public class CarParkCharges
    {
        public CarParkCharges()
        {
            Console.WriteLine("I am the carparkcharges");
        }

        public override string ToString()
        {
            return "I am the CarParkCharge()";
        }

        public double CalculateCharge(int hoursParked)
        {
            double minimumFee = 2;
            double minimumHours = 3;
            double price=0;
            if(hoursParked<minimumHours&&0<=hoursParked)
            {
                price = 2;
            }
            else if(hoursParked>minimumHours&&hoursParked<24)
            {
                price = minimumFee + 0.5 * (hoursParked - minimumHours);
            }
            else if(hoursParked>=24)
            {
                price = 10;
            }
            return price;
        }
    }
}

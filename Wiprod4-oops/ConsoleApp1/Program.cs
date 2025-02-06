using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FlightFare flightFare = new FlightFare() { FlightNo = 11, FlightName = "AirIndia", durationinhrs = 6, typedes = "International" };
            flightFare.FlightDetails();
            flightFare.FareDetails();

            //create instance for FlightFare by making as a reference to Flight which is abstract class
            Flight ff = new FlightFare() { FlightNo = 12, FlightName = "Spicejet", durationinhrs = 3, typedes = "National" };
            ff.FlightDetails();
            ff.FareDetails();
        }
    }
}

using Microsoft.VisualBasic;
using System;

namespace HotelReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hotel Reservation Program!");

            Customer customer = new Customer(CustomerType.regular);
            customer.hotelBuilder.cheapestHotel(DateTime.Parse("09/11/2020"),DateTime.Parse("09/12/2020"));
            customer.hotelBuilder.RatedHotel(DateTime.Parse("09/11/2020"), DateTime.Parse("09/12/2020"));

            Customer customer2 = new Customer(CustomerType.reward);
            customer2.hotelBuilder.cheapestHotel(DateTime.Parse("09/11/2020"), DateTime.Parse("09/12/2020"));
            customer2.hotelBuilder.RatedHotel(DateTime.Parse("09/11/2020"), DateTime.Parse("09/12/2020"));
        }
    }
}

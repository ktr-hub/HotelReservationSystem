using Microsoft.VisualBasic;
using System;

namespace HotelReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hotel Reservation Program!");
            HotelBuilder hotelBuilder = new HotelBuilder();
            hotelBuilder.addHotel("Novatel", 20000, "Regular");
            hotelBuilder.addHotel("5 star", 10000, "Regular");
            hotelBuilder.addHotel("3 star", 5000, "Regular");
            hotelBuilder.cheapestHotel(DateTime.Parse("03/14/2020"),DateTime.Parse("03/16/2020"));

        }
    }
}

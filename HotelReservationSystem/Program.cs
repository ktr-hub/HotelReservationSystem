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
            hotelBuilder.addHotel("Lakewood", 110, 90,"Regular");
            hotelBuilder.addHotel("Bridgewood", 150, 50,"Regular");
            hotelBuilder.addHotel("Ridgewood", 220, 150,"Regular");
            //hotelBuilder.cheapestHotel(DateTime.Parse("03/14/2020"),DateTime.Parse("03/16/2020"));

        }
    }
}

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
            hotelBuilder.addHotel("Lakewood", 130, 90,"Regular");
            hotelBuilder.addHotel("Bridgewood", 160, 60,"Regular");
            hotelBuilder.addHotel("Ridgewood", 220, 150,"Regular");
            hotelBuilder.cheapestHotel(DateTime.Parse("09/11/2020"),DateTime.Parse("09/12/2020"));

        }
    }
}

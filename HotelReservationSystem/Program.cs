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
            hotelBuilder.addHotel("Lakewood", 130, 90,"Regular",3);
            hotelBuilder.addHotel("Bridgewood", 160, 60,"Regular",4);
            hotelBuilder.addHotel("Ridgewood", 220, 150,"Regular",5);
            //hotelBuilder.cheapestHotel(DateTime.Parse("09/11/2020"),DateTime.Parse("09/12/2020"));
            hotelBuilder.RatedHotel(DateTime.Parse("09/11/2020"), DateTime.Parse("09/12/2020"));
        }
    }
}

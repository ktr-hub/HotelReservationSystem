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
        }
    }
}

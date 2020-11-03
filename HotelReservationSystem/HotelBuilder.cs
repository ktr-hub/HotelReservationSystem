using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelBuilder
    {
        public void addHotel(string hotelName, double rate, string customerType)
        {
            Hotel hotel = new Hotel();
            hotel.HotelName = hotelName;
            hotel.Rate = rate;
            hotel.CustomerType = customerType;
            Console.WriteLine("Hotel added successfully");
        }
    }
}

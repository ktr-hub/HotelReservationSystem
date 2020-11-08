using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public enum CustomerType{regular,reward};
    public class Customer
    {
        public HotelBuilder hotelBuilder;
        public Customer(CustomerType type)
        {
            hotelBuilder = new HotelBuilder();
            if (type == CustomerType.regular)
            {
                Console.WriteLine("\nRegular :-\n");
                hotelBuilder.addHotel("Lakewood", 130, 90,3);
                hotelBuilder.addHotel("Bridgewood", 160, 60, 4);
                hotelBuilder.addHotel("Ridgewood", 220, 150, 5);
            }
            else
            {
                Console.WriteLine("\nReward :-\n");
                hotelBuilder.addHotel("Lakewood",  80, 80, 3);
                hotelBuilder.addHotel("Bridgewood",  110, 50, 4);
                hotelBuilder.addHotel("Ridgewood",  100, 40, 5);
            }
        } 
    }
}

using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelBuilder
    {
        Dictionary<string, Hotel> hotelDictionary = new Dictionary<string, Hotel>();
        public void addHotel(string hotelName, double rate, double rate2, string customerType)
        {
            Hotel hotel = new Hotel();
            hotel.HotelName = hotelName;
            hotel.WeekDayRate = rate;
            hotel.WeekEndRate = rate2;
            hotel.CustomerType = customerType;
            Console.WriteLine("Hotel added successfully");
            hotelDictionary.Add(hotelName, hotel);
        }
     /*   public void cheapestHotel(DateTime date1,DateTime date2)
        {
            double minRate=0;
            double hotelRate;
            int numberOfDays = (date2-date1).Days;
            Hotel hotelWithMinimumRate = null;

            foreach(Hotel hotel in hotelDictionary.Values)
            {
                hotelRate = numberOfDays * hotel.Rate;
                if(minRate==0 || minRate > hotelRate)
                {
                    hotelRate = minRate;
                    hotelWithMinimumRate = hotel;
                }
            }
            Console.WriteLine(hotelWithMinimumRate.HotelName + ", Total Rate : " + hotelWithMinimumRate.Rate * numberOfDays);
        }*/

    }
}

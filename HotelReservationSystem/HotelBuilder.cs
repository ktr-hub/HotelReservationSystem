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
        public void cheapestHotel(DateTime date1,DateTime date2)
        {
            double minRate=0;
            double hotelRate;
            Hotel hotelWithMinimumRate = null;
            DateTime startDay = date1;

            foreach (Hotel hotel in hotelDictionary.Values)
            {
                hotelRate = 0;
                date1 = startDay;

                while (date2 != date1)
                {
                    string day = date1.DayOfWeek.ToString();
                    if (day.Equals("Saturday"))
                    {
                        hotelRate += hotel.WeekEndRate;
                    }
                    else
                    {
                        hotelRate += hotel.WeekDayRate;
                    }
                    date1=date1.AddDays(1);
                }
                if (minRate == 0 || minRate > hotelRate)
                {
                    minRate = hotelRate;
                    hotelWithMinimumRate = hotel;
                }
            }
            Console.WriteLine(hotelWithMinimumRate.HotelName + ", Total Rate : " + minRate);
        }

    }
}

using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelBuilder
    {
        /// <summary>
        /// Maps hotel name to its class
        /// </summary>
        Dictionary<string, Hotel> hotelDictionary = new Dictionary<string, Hotel>();

        /// <summary>
        /// UC1-addHotel
        /// </summary>
        /// <param name="hotelName"></param>
        /// <param name="WeekDayRate"></param>
        /// <param name="WeekEndRate"></param>
        /// <param name="customerType"></param>
        public void addHotel(string hotelName, double WeekDayRate, double WeekEndRate, string customerType)
        {
            Hotel hotel = new Hotel();
            hotel.HotelName = hotelName;
            hotel.WeekDayRate = WeekDayRate;
            hotel.WeekEndRate = WeekEndRate;
            hotel.CustomerType = customerType;
            Console.WriteLine("Hotel added successfully");
            hotelDictionary.Add(hotelName, hotel);
        }

        /// <summary>
        /// UC2-cheapestHotel
        /// </summary>
        /// <param name="checkInDate"></param>
        /// <param name="checkOutDate"></param>
        public void cheapestHotel(DateTime checkInDate,DateTime checkOutDate)
        {
            //Finding hotel rate for each hotel between specified dates and finally printing least of them

            Dictionary<Hotel, double> mapHotelToTotalRate = new Dictionary<Hotel, double>();

            foreach (Hotel hotel in hotelDictionary.Values)
            {
                double hotelRate = 0;
                DateTime dateIterator = checkInDate;

                while (checkOutDate >= dateIterator)
                {
                    string day = dateIterator.DayOfWeek.ToString();

                    hotelRate += (day.Equals("Saturday")) ? hotel.WeekEndRate : hotel.WeekDayRate;

                    dateIterator = dateIterator.AddDays(1);
                }

                mapHotelToTotalRate.Add(hotel, hotelRate);
            }

            var minValue = mapHotelToTotalRate.Values.Min();


            var records = from hotel in mapHotelToTotalRate
                          where hotel.Value == minValue
                          select hotel;

            Console.WriteLine("\n\nAvailable Cheap Hotels : ");
            foreach(var record in records)
            {
                Console.WriteLine("Hotel : " + record.Key.HotelName +"-->Total Rate : "+mapHotelToTotalRate[record.Key]);
            }

        }
    }
}

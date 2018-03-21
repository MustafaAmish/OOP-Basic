using System;
using System.Collections.Generic;
using System.Text;


   public class PriceCalculator
    {
        public static string CalculatePrice(string input)
        {
            var inputLine = input.Split();
            var pricePerNight = double.Parse(inputLine[0]);
            var nights = int.Parse(inputLine[1]);
            var season = Enum.Parse<Season>(inputLine[2]);
            var discount = Discount.None;
            if (inputLine.Length>3)
            {
                discount = Enum.Parse<Discount>(inputLine[3]);
            }
            var totalprice = pricePerNight * nights * (int) season;
          var  discountt = ((double) 100 - (int) discount) / 100;
          return  (totalprice*discountt).ToString("F");
        }
    }

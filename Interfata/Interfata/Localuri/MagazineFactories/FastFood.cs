using Interfata.Localuri.FastFood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Interfata.Localuri.MagazineFactories.FastFoodType;

namespace Interfata.Localuri.MagazineFactories
{
    public class FastFood : ILocalFactory
    {
        public Locale MakeFastFood(FastFoodType type)
        {
            switch (type)
            {

                case MCDONALDS: 
                    return new McDonalds();
                case KFC:
                    Console.WriteLine("JARATICULE!");
                    return new Kfc();
                default: 
                    return null;

            }
        }
        public Locale MakeRestaurant(RestaurantType type)
        {
            return null;
        }
    }
}

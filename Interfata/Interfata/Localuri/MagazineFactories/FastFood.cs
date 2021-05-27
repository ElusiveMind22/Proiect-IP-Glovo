using Interfata.Localuri.FastFood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Interfata.Localuri.MagazineFactories.FastFoodType;

namespace Interfata.Localuri.MagazineFactories
{
    public class FastFood : IMagazinFactory
    {
        public Magazine MakeFastFood(FastFoodType type)
        {
            switch (type)
            {

                case MCDONALDS: return new McDonalds();
                case KFC: return new Kfc();
                default: return null;

            }
        }
        public Magazine MakeRestaurant(RestaurantType type)
        {
            return null;
        }
    }
}

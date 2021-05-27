using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Interfata.Localuri.MagazineFactories.RestaurantType;
using Interfata.Localuri.Restaurante;
namespace Interfata.Localuri.MagazineFactories
{
    public class Restaurant:IMagazinFactory
    {
 

        public Magazine MakeRestaurant ( RestaurantType type)
        {
            switch (type)
            {

                case SPLENDEAT: return new SplendEat();
                case NOODLEPACK: return new NoodlePack();
                case LACUIB: return new LaCuib();
                case OXFORD: return new Oxford();
                case CARTUF: return new Cartuf();
                case MAMMAMIA: return new MammaMia();
                case DELICIO: return new Delicio();
                default: return null;
                   
            }
        }
        public Magazine MakeFastFood(FastFoodType type)
        {
            return null;
        }
    }
}

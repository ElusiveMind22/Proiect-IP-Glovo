using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LocaluriLibrary.Localuri.MagazineFactories.RestaurantType;
using LocaluriLibrary.Localuri.Restaurante;
namespace LocaluriLibrary.Localuri.MagazineFactories
{
    public class Restaurant:ILocalFactory
    {
 

        public Locale MakeRestaurant ( RestaurantType type)
        {
            switch (type)
            {

                case SPLENDEAT:
                    return new SplendEat();
                case NOODLEPACK: 
                    return new NoodlePack();
                case LACUIB: 
                    return new LaCuib();
                case OXFORD: 
                    return new Oxford();
                case CARTUF: 
                    return new Cartuf();
                case MAMMAMIA:
                    return new MammaMia();
                case DELICIO: 
                    return new Delicio();
                default: 
                    return null;
                   
            }
        }
        public Locale MakeFastFood(FastFoodType type)
        {
            Console.WriteLine("NU POTI IMPLEMENTA UN FASTFOOD CU UN MAKERESTAURANT!");
            return null;
        }
    }
}

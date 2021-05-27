using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfata.Localuri.MagazineFactories
{
    public interface IMagazinFactory
    {
         Magazine MakeFastFood( FastFoodType type);
         Magazine MakeRestaurant( RestaurantType type);
    }
}

using LocaluriLibrary.Localuri.MagazineFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaluriLibrary.Localuri.Restaurante
{
    /// <summary>
    /// Clasa ce mosteneste clasa abstracta MagazineRestaurant.
    /// </summary>
    public class Oxford : MagazineRestaurante
    {

        /// <summary>
        /// Constructor ce atribuie valorile specifice restaurantului.
        /// </summary>
        public Oxford() : base()
        {

            //Atribuire Variabile

            _meniu = new string[8];
            _meniu[0] = "Salata cu naut";
            _meniu[1] = "Irish nachos";
            _meniu[2] = "BLT Chicken Salad";
            _meniu[3] = "Chicken bites";
            _meniu[4] = "Paste Arrabiata";
            _meniu[5] = "Mozzarella sticks";
            _meniu[6] = "Chicken fingers";
            _meniu[7] = "Sos maioneza cu usturoi";

            _preturi = new double[8];
            _preturi[0] = 26;
            _preturi[1] = 15;
            _preturi[2] = 22;
            _preturi[3] = 24;
            _preturi[4] = 20;
            _preturi[5] = 12;
            _preturi[6] = 22;
            _preturi[7] = 2;

            _numeleDeLocal = "Oxford";

            // Gettere - Settere.

            Meniu = _meniu;
            Preturi = _preturi;
            NumeleDeLocal = _numeleDeLocal;
            TipDeLocal = _tipDeLocal;
        }

    }
}

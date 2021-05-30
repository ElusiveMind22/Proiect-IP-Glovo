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
    public class Delicio : MagazineRestaurante
    {
        /// <summary>
        /// Constructor ce atribuie valorile specifice restaurantului.
        /// </summary>
        public Delicio() : base()
        {

            //Atribuire Variabile

            _meniu = new string[8];
            _meniu[0] = "Pizza Margherita";
            _meniu[1] = "Pizza Diavola";
            _meniu[2] = "Pizza Salami";
            _meniu[3] = "Pizza Vegetariana";
            _meniu[4] = "Pizza Pollo";
            _meniu[5] = "Paste Carbonara";
            _meniu[6] = "Paste Bolognese";
            _meniu[7] = "Paste Matriciana";

            _preturi = new double[8];
            _preturi[0] = 17.99;
            _preturi[1] = 17.99;
            _preturi[2] = 16.99;
            _preturi[3] = 18.99;
            _preturi[4] = 18.99;
            _preturi[5] = 24;
            _preturi[6] = 24.99;
            _preturi[7] = 23.99;

            _numeleDeLocal = "Delicio";

            // Gettere - Settere.

            Meniu = _meniu;
            Preturi = _preturi;
            NumeleDeLocal = _numeleDeLocal;
            TipDeLocal = _tipDeLocal;
        }

    }
}
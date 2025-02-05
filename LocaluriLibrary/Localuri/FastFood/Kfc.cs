﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaluriLibrary.Localuri.FastFood
{

    /// <summary>
    /// Clasa ce mosteneste clasa abstracta MagazineFastFood.
    /// </summary>
    public class Kfc:MagazineFastFood
    {
        /// <summary>
        /// Constructor ce atribuie valorile specifice restaurantului.
        /// </summary>
        public Kfc():base()
        {
            //Atribuire Variabile

            _meniu = new string[8];
            _meniu[0] = "Aripioare";
            _meniu[1] = "CartofiPrajiti";
            _meniu[2] = "Nuggets";
            _meniu[3] = "Pui";
            _meniu[4] = "Gaina";
            _meniu[5] = "MartziBucket";
            _meniu[6] = "Grigore";
            _meniu[7] = "CucuDinTei";

            _preturi = new double[8];
            _preturi[0] = 5;
            _preturi[1] = 10;
            _preturi[2] = 12;
            _preturi[3] = 15;
            _preturi[4] = 11;
            _preturi[5] = 9;
            _preturi[6] = 5;
            _preturi[7] = 100;

            
            _numeleDeLocal = "KFC";

            // Gettere - Settere.

            Meniu = _meniu;
            Preturi = _preturi;
            NumeleDeLocal = _numeleDeLocal;
            TipDeLocal = _tipDeLocal;

        }
    }
}

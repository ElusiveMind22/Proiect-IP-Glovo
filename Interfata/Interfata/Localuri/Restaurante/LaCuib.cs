using Interfata.Localuri.MagazineFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfata.Localuri.Restaurante
{

    public class LaCuib : MagazineRestaurante
    {
        public LaCuib() : base()
        {
            _meniu = new string[8];
            _meniu[0] = "Mancare";
            _meniu[1] = "Mancare";
            _meniu[2] = "Mancare";
            _meniu[3] = "Mancare";
            _meniu[4] = "Mancare";
            _meniu[5] = "Mancare";
            _meniu[6] = "Mancare";
            _meniu[7] = "Mancare";

            _preturi = new double[8];
            _preturi[0] = 1;
            _preturi[1] = 1;
            _preturi[2] = 1;
            _preturi[3] = 1;
            _preturi[4] = 1;
            _preturi[5] = 1;
            _preturi[6] = 1;
            _preturi[7] = 1;

            _numeleDeLocal = "LaCuib";

            Meniu = _meniu;
            Preturi = _preturi;
        }

    }
}

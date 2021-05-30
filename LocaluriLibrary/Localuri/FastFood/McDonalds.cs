using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaluriLibrary.Localuri.FastFood
{
   public class McDonalds:MagazineFastFood
    {
        public McDonalds():base()
        {
            _meniu = new string[8];
            _meniu[0] = "Big Mac";
            _meniu[1] = "McChicken";
            _meniu[2] = "Dulblu Cheeseburger";
            _meniu[3] = "Chicken Grill";
            _meniu[4] = "Chicken McNuggets";
            _meniu[5] = "Big Tasty";
            _meniu[6] = "Royal Deluxe";
            _meniu[7] = "Fillet-O-Fish";

            _preturi = new double[8];
            _preturi[0] = 18;
            _preturi[1] = 14;
            _preturi[2] = 9;
            _preturi[3] = 12;
            _preturi[4] = 24;
            _preturi[5] = 13;
            _preturi[6] = 18;
            _preturi[7] = 27;

            _numeleDeLocal = "McDonalds";

            Meniu = _meniu;
            Preturi = _preturi;
            Meniu = _meniu;
            Preturi = _preturi;
            NumeleDeLocal = _numeleDeLocal;
            TipDeLocal = _tipDeLocal;

        }

    }
}

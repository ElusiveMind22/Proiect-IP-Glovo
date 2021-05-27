using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfata.Localuri.Restaurante
{
    public abstract class MagazineRestaurante : Magazine
    {
        public MagazineRestaurante(string[] meniu, string[] preturi, string tipDeLocal, string numeleDeLocal)
            {

            base(meniu, preturi, tipDeLocal, numeleDeLocal);

            }


    }
}

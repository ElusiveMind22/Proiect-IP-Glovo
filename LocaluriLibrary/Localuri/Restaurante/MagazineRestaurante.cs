using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaluriLibrary.Localuri.Restaurante
{
    public abstract class MagazineRestaurante : Locale  
    {

          public MagazineRestaurante():base()
        {
            _tipDeLocal = "Restaurant";
        }
    }
}

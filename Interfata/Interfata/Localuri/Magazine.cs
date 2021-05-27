using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfata.Localuri
{
    public abstract class Magazine
    {
        protected string[] _meniu;
        protected string[] _preturi;
        protected string _tipDeLocal;
        protected string _numeleDeLocal;

        public Magazine(string[] meniu, string[] preturi, string tipDeLocal, string numeleDeLocal)
        {
            _meniu = meniu;
            _preturi = preturi;
            _tipDeLocal = tipDeLocal;
            _numeleDeLocal = numeleDeLocal;
        }
    }


}

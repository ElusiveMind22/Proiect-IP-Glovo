using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfata.Localuri
{
    public abstract class Locale
    {
        protected string[] _meniu;
        protected double[] _preturi;
        protected string _tipDeLocal;
        protected string _numeleDeLocal;

        public Locale()
        {

        }
        
        public string[] Meniu { get; set; }
        public double[] Preturi { get; set; }
        public string TipDeLocal { get; set; }
        public string NumeleDeLocal { get; set; }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseObjekti11
{
    class Stablo:Biljka
    {
        bool opadajuListovi;

        public bool OpadajuListovi1 { get => opadajuListovi; set => opadajuListovi = value; }

        Stablo(bool OpadajuListovi)
        {
            this.opadajuListovi = OpadajuListovi;
        }
    }
}

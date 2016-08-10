using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VererbungGrundlagen_Buecherei
{
    class Software : AusleihbaresMedium
    {
        public override bool KannAusgeliehenWerden(DateTime gewuenschtesAusleihDatum)
        {
            if (istAusgeliehen)
            {
                return false;
            }

            if (BerechneDifferenzInTagen(DateTime.Now, gewuenschtesAusleihDatum) > 7.0)
            {
                return false;
            }

            return true;

        }
    }
}

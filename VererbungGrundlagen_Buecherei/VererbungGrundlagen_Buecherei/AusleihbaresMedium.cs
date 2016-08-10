using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VererbungGrundlagen_Buecherei
{
    public class AusleihbaresMedium
    {
        private bool istAusgeliehen = false;
        // TODO: JS, was ist eine sinnvolle Initialisierung?
        private DateTime ausgeliehenBis;

        public bool KannAusgeliehenWerden(DateTime gewuenschtesAusleihDatum)
        {
            if (istAusgeliehen)
            {
                return false;
            }

            if (BerechneDifferenzInTagen(DateTime.Now, gewuenschtesAusleihDatum) > 30)
            {
                return false;
            }

            return true;
        }

        private int BerechneDifferenzInTagen(DateTime von, DateTime bis)
        {
            TimeSpan differenz = bis.Subtract(von);
            return differenz.Days;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VererbungGrundlagen_Buecherei
{
    class Program
    {
        static void Main(string[] args)
        {
            Software unity = new Software();
            DateTime ausleihEndeIn15Tagen = DateTime.Now.AddDays(15);
            DateTime ausleihEndeIn6Tagen = DateTime.Now.AddDays(6);

            if (unity.KannAusgeliehenWerden(ausleihEndeIn6Tagen))
            {
                Console.WriteLine("ERFOLG: Software kann für 6 Tage ausgeliehen werden.");
            }

            if (!unity.KannAusgeliehenWerden(ausleihEndeIn15Tagen))
            {
                Console.WriteLine("ERFOLG: Software kann nicht 15 Tage ausgeliehen werden.");
            }

            Console.ReadLine();
        }
    }
}

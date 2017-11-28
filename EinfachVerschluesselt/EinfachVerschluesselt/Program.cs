using System;

namespace EinfachVerschluesselt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Text (unsicher) verschlüsseln mit ROT-13!");
            Console.WriteLine();

            // Text vom Benutzer eingeben lassen
            string zuverschluesselnderText;
            Console.WriteLine("Bitte gib den zuverschlüsselnden Text ein:");
            zuverschluesselnderText = Console.ReadLine();

            // Text verschlüsseln
            string verschluesselterText = VerschluesselnMitRot13(zuverschluesselnderText);

            // verschlüsselten Text ausgeben
            Console.WriteLine();
            Console.WriteLine($"Der verschlüsselte Text lautet: {verschluesselterText}");
            Console.WriteLine();

            // Warten bis der Benutzer das Programm beendet
            Console.WriteLine("Zum Beenden bitte 'Enter' drücken");
            Console.ReadLine();
        }

        private static string VerschluesselnMitRot13(string unverschluesselterText)
        {
            // Alles in Großbuchstaben konvertieren
            string resultat;
            resultat = unverschluesselterText.ToUpper();

            // Umlaute entfernen (normalisieren)
            resultat = resultat.Replace("Ö", "OE");
            resultat = resultat.Replace("Ä", "AE");
            resultat = resultat.Replace("Ü", "UE");
            resultat = resultat.Replace("ß", "SS");

            // Zahlen und Sonderzeichen ignorieren
            // Alle Buchstaben um 13 Stellen verschieben
            char[] einzelneZeichen = resultat.ToCharArray();
            int zeichen = Convert.ToUInt16(einzelneZeichen[0]) + 13;

            resultat = Convert.ToChar(zeichen).ToString();
            return resultat;
        }
    }
}

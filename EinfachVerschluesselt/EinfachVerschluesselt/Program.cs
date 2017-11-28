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
            string verschluesselterText = "Verschlüsselung noch nicht implementiert!";

            // verschlüsselten Text ausgeben
            Console.WriteLine();
            Console.WriteLine($"Der verschlüsselte Text lautet: {verschluesselterText}");
            Console.WriteLine();

            // Warten bis der Benutzer das Programm beendet
            Console.WriteLine("Zum Beenden bitte 'Enter' drücken");
            Console.ReadLine();
        }
    }
}

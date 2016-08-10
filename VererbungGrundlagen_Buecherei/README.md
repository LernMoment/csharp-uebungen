# C# Übung - Ausleihen von Medien in einer Bücherei (Vererbung & Polymorphismus)

**Übungsfokus:** Klassen ableiten, virtuelle Methoden erstellen, Verwenden des Zugriffsmodifizierers `protected`, Datentyp [DateTime](https://msdn.microsoft.com/de-de/library/system.datetime(v=vs.110).aspx) und Polymorphismus

**Geschätzte Übungsdauer:** ca. 20-45 Minuten

Es geht darum, dass du eine kleine Konsolenanwendung schreibst, mit der verschiedene Medien (in diesem Beispiel Videos und Software) in einer Bücherei ausgeliehen werden können.

Dabei ist es nicht wichtig, dass du eine tolle Anwendung erstellst, sondern das du übst, wie du *abgeleitete Klassen* erstellst. Neben der eigentlichen Vererbung sollst du auch eine virtuelle Methode in einer Basisklasse erstellen und diese in einer abgeleiteten Klasse überschreiben.

## In kleinen Schritten zum Ziel

Um dich in kleinen Aufgaben zum Ziel zu leiten, habe ich hier die einzelnen Teilaufgaben aufgeschrieben:

 1. Erstelle eine Basisklasse `AusleihbaresMedium`. Diese enthält die Attribute `istAusgeliehen` und `ausgeliehenBis`. Zusätzlich stellt sie die Methoden `bool KannAusgeliehenWerden(DateTime datum)` und `void AusleihenBis(DateTime ausleihDatum)` zur Verfügung. Dabei überprüft die erste Methode ob das Medium bereits ausgeliehen ist und ob die allgemeine Ausleihfrist von 30 Tagen nicht überschritten wird. Die zweite Methode setzt die beiden Attribute entsprechend, wenn ein ausleihen möglich ist.
 2. Um die Methoden und die Klasse zu testen, erstelle eine Instanz der Klasse `AusleihbaresMedium` in `Main`. Rufe die Methode `KannAusgeliehenWerden` mit verschiedenen Werten auf (heute + 15 Tage, heute + 30 Tage und heute + 31 Tage). Der Datentyp `DateTime` bietet dir dafür hilfreiche Eigenschaften und Methoden an.
 3. Leite eine Klasse `Video` von `AusleihbaresMedium` ab. Diese Klasse hat lediglich eine Eigenschaft vom Datentyp string mit dem Namen `Produzent`. Sonst macht sie nichts weiter! Teste auch eine Instanz dieser Klasse in Main und beobachte, ob sie tatsächlich die gleichen Methoden wie `AusleihbaresMedium` anbietet und ob sich diese Methoden auch gleich verhalten.
 4. Leite eine Klasse `Software` von `AusleihbaresMedium` ab. Eine Software darf in der Bücherei max. 1 Woche ausgeliehen werden. Erweitere also die Methode `KannAusgeliehenWerden` so, dass sie in der abgeleiteten Klasse `Software` überschrieben wird und anstelle von 30 Tagen Ausleihfrist nur 7 Tage verwendet. Teste die Klasse in dem du eine Instanz von ihr in `Main` anlegst und die Methoden aufrufst.
 5. Erstelle nun in `Main` eine `List<AusleihbaresMedium>` in der du Instanzen von `Video` und `Software` speicherst. Damit hast du bereits eine wichtigen Teil von Polymorphismus umgesetzt. Da du in der vorherigen Teilaufgabe eine virtuelle Methode an der Basisklasse definiert hast und diese in einer abgeleiteten Klasse überschrieben hast, kannst du nun auch den weiteren Aspekt von Polymorphismus sehen. Erweitere `Main` so, dass du über deine Liste iterierst (`foreach`) und für jeden Eintrag `KannAusgeliehenWerden` mit unterschiedlicher Ausleihfrist aufrufst (z.B. heute + 5 Tage, heute + 9 Tage, heute + 27 Tage und heute + 50 Tage). Wenn du dir jedesmal ausgeben lässt, ob dein Medium ausgeliehen werden kann, wirst du sehen, dass (sofern vorhanden) automatisch die Implementierung der Methode der abgeleiteten Klasse verwendet wird.

## Lösung

Hast du die Aufgabe umgesetzt, oder willst du nur ein wenig spicken? Mach es dir nicht zu einfach ;-). Du willst schließlich was lernen, oder?

Meine Lösung zu den Teilaufgaben verfolgst du am besten direkt in der Historie des Quellcodes. Nachfolgend habe ich die jeweiligen Versionsstände verlinkt und noch ein paar allgemeine Hinweise zur Lösung bereitgestellt:

 1. Meine Lösung zur ersten Teilaufgabe kannst du [hier sehen](https://github.com/LernMoment/csharp-uebungen/blob/615b9c68f66a72a96839e02239bcb15c75742d74/VererbungGrundlagen_Buecherei/VererbungGrundlagen_Buecherei/AusleihbaresMedium.cs). Um eine möglichst gute Datenkapselung zu erreichen habe ich sowohl die Attribute wie auch die Methode `BerechneDifferenzInTagen` als `private` markiert. Somit kann niemand direkt an die Daten der Klasse kommen.
 2. Meine Lösung zu dieser Teilaufgabe [findest du hier](https://github.com/LernMoment/csharp-uebungen/blob/40d48f8649d2964d489f09231a187eb6584c4e0a/VererbungGrundlagen_Buecherei/VererbungGrundlagen_Buecherei/Program.cs). Achte insbesondere auf die Verwendung von `DateTime`. Sowohl die Eigenschaft `Now` wie auch die Methode `AddDays` sind sehr hilfreiche Methoden. Mehr zum Datentyp `DateTime` erkläre ich dir [in diesem Video](https://youtu.be/Rlu5rPAQQwk?list=PLP2TrPpx5VNkr-wmkjguVZAvN4T5EPJbF).
 3. Meine Lösung zu dieser Teilaufgabe findest du in [Video.cs](https://github.com/LernMoment/csharp-uebungen/blob/502a8d27189add6bbc77bf4875e6a422acd63614/VererbungGrundlagen_Buecherei/VererbungGrundlagen_Buecherei/Video.cs) und in [Program.cs](https://github.com/LernMoment/csharp-uebungen/blob/502a8d27189add6bbc77bf4875e6a422acd63614/VererbungGrundlagen_Buecherei/VererbungGrundlagen_Buecherei/Program.cs).
 4. Zur Lösung dieser Aufgabe habe ich [AusleihbaresMedium.cs, Software.cs und Program.cs](https://github.com/LernMoment/csharp-uebungen/tree/754672d540ec83d39e0007d38866de90b52de2e1/VererbungGrundlagen_Buecherei/VererbungGrundlagen_Buecherei) angepasst. Damit `Software` auf das Attribut `istAusgeliehen` und die Methode `BerechneDifferenzInTagen` zugreifen kann, musste ich diese von `private` auf `protected` setzen. Das wichtigste jedoch ist die Verwendung von `virtual` in der Klasse `AusleihbaresMedium` und `override` in der Klasse `Software`. Nur so ist es möglich, dass später der Polymorphismus funktionieren wird.
 5. Meine Lösung zu dieser Teilaufgabe [findest du hier](https://github.com/LernMoment/csharp-uebungen/blob/f34f6594042366b37b26db78332090d79241aada/VererbungGrundlagen_Buecherei/VererbungGrundlagen_Buecherei/Program.cs).

Damit hast du die komplette Übung abgearbeitet. Hast du nicht etwas vergessen? Denke daran, dass du nach der Übung reflektierst was dir die Übung gebracht hat und was du vielleicht beim nächsten mal besser, anders, ... machen kannst.

Viel Spaß beim weiteren Üben, Lernen, Arbeiten oder auch einfach Feierabend machen

Jan

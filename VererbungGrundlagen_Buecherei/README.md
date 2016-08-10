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
 4. Leite eine Klasse `Software` von `AusleihbaresMedium` ab. Eine Software darf in der Bücherei max. 1 Woche ausgeliehen werden. Erweitere also die Methode `KannAusgeliehenWerden` so, dass sie in der abgeleiteten Klasse `Software` überschrieben wird und anstelle von 30 Tagen Ausleihfrist nur 7 Tage verwendet.
 5. Erstelle nun in `Main` eine `List<AusleihbaresMedium>` in der du Instanzen von `Video` und `Software` speicherst. Damit hast du bereits eine wichtigen Teil von Polymorphismus umgesetzt. Da du in der vorherigen Teilaufgabe eine virtuelle Methode an der Basisklasse definiert hast und diese in einer abgeleiteten Klasse überschrieben hast, kannst du nun auch den weiteren Aspekt von Polymorphismus sehen. Erweitere `Main` so, dass du über deine Liste iterierst (`foreach`) und für jeden Eintrag `KannAusgeliehenWerden` mit unterschiedlicher Ausleihfrist aufrufst (z.B. heute + 5 Tage, heute + 9 Tage, heute + 27 Tage und heute + 50 Tage). Wenn du dir jedesmal ausgeben lässt, ob dein Medium ausgeliehen werden kann, wirst du sehen, dass (sofern vorhanden) automatisch die Implementierung der Methode der abgeleiteten Klasse verwendet wird.



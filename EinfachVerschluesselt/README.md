# C# Übung - Texte einfach verschlüsseln (mit ROT13)
Diese Übung basiert auf der wunderbaren [Coding Kata "ROT-13"](http://ccd-school.de/coding-dojo/function-katas/rot-13/) der [Clean Code Developer School](http://ccd-school.de).

  - **Übungsfokus:** String, Kontrollstrukturen (for-Schleife, if-Abfrage), Problemlösung (vom Problem zum Code), Arbeiten in kleinen abgeschlossenen Schritten 
  - **Geschätzte Übungsdauer:** ca. 30-60 Minuten
  - **Schwierigkeitsgrad:** *Einsteiger* & *Fortgeschrittene*

  In dieser Übung geht es darum, dass du

   - lernst wie du von einer "einfachen" Problemstellung zu einem funktionsfähigen Quellcode kommst.
   - den Datentyp [string]() inklusive einiger seiner wichtigen Funktionen verwendest.
   - einzelne Zeichen eines `String` manipulierst.
   - Kontrollstrukturen wie die `for`-Schleife und die `if`-Abfrage verwendest.
   - ein `Array` verwendest.

## Übungsbeschreibung
> ROT13 (engl. rotate by 13 places, zu Deutsch in etwa „rotiere um 13 Stellen“) ist eine Caesar-Verschlüsselung (auch Verschiebechiffre genannt), mit der auf einfache Weise Texte verschlüsselt werden können. [...]
>  ROT13 ist nicht zur sicheren Verschlüsselung gedacht, es wird im Gegensatz dazu sogar oft als Beispiel für eine schwache, unsichere Verschlüsselung genannt. Vielmehr dient ROT13 dazu, einen Text unlesbar zu machen, also zu verschleiern, so dass eine Handlung des Lesers erforderlich ist, um den ursprünglichen Text lesen zu können.
> -- [Wikipedia](https://de.wikipedia.org/wiki/ROT13)

In dieser Übung geht es darum, dass du dem Anwender erlaubst einen beliebigen Text einzugeben und dieser dann entsprechend den folgenden Regeln (abgeleitet von der zugrundeliegenden [Coding Kata](http://ccd-school.de/coding-dojo/function-katas/rot-13/) - DANKE an Clean Code Developer School!) verschlüsselt und anschließend ausgegeben wird:

 1. Es werden nur Buchstaben verschlüsselt (Zahlen und Sonderzeichen bleiben an gleicher Stelle erhalten)
 2. Kleinbuchstaben werden vor ihrer Verschlüsselung in Großbuchstaben konvertiert (der verschlüsselte Text besteht also nur aus Großbuchstaben und verliert somit die Information über Groß- und Kleinschreibung). Der Benutzer soll die Möglichkeit haben Großbuchstaben und Kleinbuchstaben einzugeben! Die Konvertierung in Großbuchstaben wird erst vor der Verschlüsselung durch geführt.
 3. Umlaute werden "normalisiert". D.h. "ü" -> "UE", "ö" -> "OE", "ä" -> "AE", "ß" -> "SS"

Verschlüsselt heißt dabei, dass jeder Buchstabe um 13 Stellen *"nach rechts"* verschoben wird (z.B. A -> N). Wird bei der Verschiebung das *Z* "passiert", dann wird wieder bei *A* angefangenen (z.B. O -> B).

Bei der Umsetzung dieser Übung solltest du darauf achten, dass du dir die Übung in kleine einfache Schritte unterteilst und diese auch separat umsetzt. Der Fokus sollte (erstmal) darauf liegen eine funktionierende Lösung zu erstellen. Weitere Aspekte wie "gute" Objektorientierung, "sauberer" Quellcode, "tolle" Oberfläche bzw. Benutzerführung würde ich erstmal nicht beachten. Das sind alles Varianten in der du diese Übung nochmals ausführen kannst.

## Testdaten
Mit folgenden Texten kannst du dein Programm überprüfen ob es richtig funktioniert:

| Ausgangstext | Verschlüsselter Text |
| ------------ | -------------------- |
| Hallo | UNYYB |
| Es ist gerade 7:21 Uhr am Dienstag Morgen | RF VFG TRENQR 7:27 HUE NZ QVRAFGNT ZBETRA |
| Übung macht besser ;-) | HROHAT ZNPUG ORFFRE ;-) |

## Tipps zur Lösung
Gerade als Anfänger ist es manchmal schwer solche Aufgaben zu lösen, einfach weil es viel zu viel Unbekannte gibt. Daher möchte ich dir hier ein paar Tipps geben die du verwenden kannst, wenn du mit der Lösung der Übung nicht weiter kommst.

### Tipp 1 - Fokus auf einzelne kleine Schritte

Um die komplette Aufgabe lösen zu können, musst du unterschiedliche Teilaufgaben erledigen. Daher macht es Sinn, dass du diese Teilaufgaben identifizierst und dann jede einzelnd (und fokussiert) erledigst. Hier hinter steht das allgemeine Prinzip *"Teile und Herrsche"*. D.h. es geht einfacher, wenn du eine komplexe Aufgabe solange in einzelne Teilaufgaben unterteilst, bis jede Teilaufgabe *"einfach"* umzusetzen ist.

Ich habe beispielsweise gesehen, dass ich die Übung in zwei Bereiche unterteilen kann:

 1. Interaktion mit dem Benutzer - hierbei geht es darum, dass ich den Text vom Benutzer erfrage, ihm den verschlüsselten Text anzeige und dann warte bis er die Anwendung beendet.
 2. Text verschlüsseln - dieses ist die eigentliche Aufgabe, welche wiederum aus weiteren Teilaufgaben besteht: Text in Großbuchstaben konvertieren, Umlaute "entfernen", Zahlen und Sonderzeichen ignorieren und schließlich alle Buchstaben um 13 Stellen verschieben.

Nun kann ich die einzelnen Bereiche und Teilaufgaben komplett los gelöst von einander umsetzen. Das ist wichtig, damit ich mich immer nur auf einen kleinen Teil konzentrieren kann und mich nicht von anderen Teilaufgaben ablenken lasse.

Damit ich das große Ganze im Auge behalte schreibe ich mir die einzelnen Schritte als Kommentare direkt in den Quelltext. Nun kann ich für jede Teilaufgabe unterhalb des entsprechenden Kommentars den passenden Quelltext schreiben. Damit habe ich nicht nur die Lösung und eine Dokumentation, sondern wenn ich später den Quelltext umstruktiere, kann ich anhand dieser Kommentare sehen wo potentielle Methoden sind.

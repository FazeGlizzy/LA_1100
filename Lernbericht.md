# Lern-Bericht
Steven Salie

## Einleitung

Ich habe in diesem Projekt einen random number generator erstellt der zufällige Zahlen und auch Buchstaben generieren kann, der dir dann ermöglicht
das du erraten kannst welche Zahl / Buchstabe generiert wurde, ob du höher / tiefer bist und wieviele Versuche du gebraucht hast.

## Was habe ich gelernt?

Ich werde euch ich diesem Lernbericht erläutern wie man ein `do-while` statement benutzt und für was es zu gebrauchen ist.

## Beschreibung

Um eine Schleife mit `do-while` zu verwenden, musst du nur eine Bedingung definieren, unter der bestimmter Code ausgeführt wird.
Die Bedingung für eine do-while-Schleife kann ein einfacher Boolean sein.
Die Schleife wird so lange ausgeführt, bis die Bedingung nicht mehr true ist (Wird später im Beispiel gezeigt).
Du kannst auch eine neue Schleife innerhalb einer Schleife erstellen.
Zudem kannst du als erstes den Code, der ausgeführt werden soll, definieren und danach die Bedingung. Dafür musst du zuerst do angeben, danach while mit der Bedingung.

```csharp

bool antwort = false;
int i = 0;
bool weiter = true;
char auswahl = 0;

//do lässt als erstes den Code laufen und dann werden die Bedingungen für eine wiederholung geprüft.
do
{
    Console.WriteLine("Wähle ein Essen aus [1|2|3]");
    auswahl = Convert.ToChar(Console.ReadLine());
    
    switch(auswahl)
    {
        case 1:
          Console.WriteLine("Du hast Kuchen bekommen");
          break;
        
        case 2:
          Console.WriteLine("Du hast Pizza bekommen");
          break;
        
        case 3:
          Console.WriteLine("Du hast Burger bekommen");
          break;
    }
    
    //Hier wird das while zuerst geschrieben heisst, das while prüft immer am Anfang ob die Bedingungen stimmen.
    while(i < 5 || weiter == true)
    {
        Console.WriteLine("Du nimmst einen Biss");
        Console.WriteLine("Willst du einen weiteren nehmen? [true|false]");
        weiter = Convert.ToBoolean(Console.ReadLine());

    }
    
    Console.WriteLine("Willst du etwas anderes probieren? [true|false]")
    antwort = Convert.ToBoolean(Console.ReadLine);
    
}while (antwort == false)
```

![Pap do while](https://user-images.githubusercontent.com/89085881/191745540-4d8d637b-2b4a-40b9-9998-74103c67bce9.PNG)

## Verifikation

Ich konnte aus freiem Denken den obrigen Code erstellen was für mich ein sehr guter Indiz ist das ich die `do-while` schleife beherrsche

# Reflexion zum Arbeitsprozess

👍 Was gut an meiner Arbeit lief:
    Ich hatte schon sehr viel Vorwissen und konnte diese Pefekt anwenden und sehr schnell sehr viel Vortschritt           machen bei meiner Arbeit. Die Programmierung lief sehr gut und die Ideen kahmen sehr schnell zu verbesserungen.


👎 und etwas, was nicht gut lief:
    Ich hatte durch die schnelle Arbeit sehr viel Zeit in der ich weniger gemacht habe da ich schon so schnell so         weit war und habe dann auch nicht mehr gearbeitet.


**VBV**: Ich hätte mehr aus meiner freien Zeit machen sollen, da ich schneller fertig war.

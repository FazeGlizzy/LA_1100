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

* Eine textliche Beschreibung
* Ein deutliches, aussagekräftiges Bild oder eine kommentierte Bildschirm-Aufnahme
* Ein gut dokumentierter Code-Fetzen
* Ein Link zu einem *selbst aufgenommenen* youtube-Video oder `.gif`.

## Verifikation

✍️ Erklären Sie kurz und bündig, inwiefern die von Ihnen verwendeten Medien zeigen, was Sie gelernt haben.

# Reflexion zum Arbeitsprozess

👍 Überlegen Sie sich jeweils etwas, was gut an Ihrer Arbeit lief; 

👎 und etwas, was nicht gut lief.

**VBV**: ✍️ Formulieren Sie davon ausgehend einen *handelbaren* Verbesserungsvorschlag.

# Projekt-Dokumentation

Steven Salie

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|   01.09    | 1.0.1   |  Eine Zufällige Zahl generien und sie versuchen zu erraten können |
|   08.09    | 1.0.2     |  Das Prgramm sich wiederholen lassen und weitere eingaben tätigen                                                            |
|   15.09    | 1.0.3   |   Feinschliff und einfügen von RandomLetterGenerator                                                           |

## 1 Informieren

### 1.1 Ihr Projekt

Random Number Generator wo am geschickt erraten muss welche Zahl generiert wurde

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |      Muss       | Funktion |Eine zufällige Zahl muss erstellt werden |
| 2    |      Muss       | Funktion |Man muss eine Zahl eingeben können       |
| 3    |      Muss       | Funktion |Es muss erkennen ob die Zahl zu klein, zu gross, falsch oder richtig ist|
| 4    |      Muss       | Funktion |Das Programm muss dem Nutzer eine weitere Chance (Eingabe) geben |
| 5    |      Muss       | Funktion |Muss falls richtige Zahl erraten wurde, abfragen können ob das Programm wiederholt werden sollte |
| 6    |      Muss       | Funktion |Das Programm muss wiederholt werden können |
| 7    |      Muss       | Qualität |Muss Versuche anzeigen können |
| 8    |      Kann       | Funktion |Kann einen Timer haben der nach einer bestimmten Zeit abläuft|
| 9    |      Kann       | Funktion |Kann einen Modus haben wo du einen Buchstaben im ABC erraten musst|

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Programm startet | - | Random Zahl wird erstellt |
| 2.1  | Man wird gefragt | schreiben | Zahl wird gespeichert |
| 3.1  | Zahl wird gecheckt | - | Anzeige ob Zahl zu klein/gross |
| 3.2  | Zahl wird gecheckt | - | Anzeige ob Zahl zu falsch/richtig |
| 4.1  | Bei falscher Zahl | weitere zahl | Das Programm wird wiederholt |
| 5.1  | Richtige Zahl | - | fragen ob Programm wiederholen |
| 6.1  | true bei 5.1 | - | Programm wird wiederholt |
| 7.1  | Richtige Zahl | - | Anzahl Versuche wird angezeigt |
| 8.1  | Bei Programmstart | - | Timer mit ablaufzeit wird gestartet |
| 9.1  | Bei Programmstart auswählen ob Zahlen oder Buchstaben | a oder b | Zahl oder Buchstaben wird gewählt |

### 1.4 Diagramme

![RNG](https://user-images.githubusercontent.com/89085881/186608807-bb4d034e-27c4-4148-9091-e8ac0f4975e9.png)

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |  01.09.2022 | Ich | Random number programmieren | 1x45 |
| 2.A  |  01.09.2022 | Ich | Eingabe Zahl | 1x45 |
| 3.A  |  01.09.2022 | Ich | Erkennen ob Zahl zu gross/klein/falsch/richtig ist | 2x45 |
| 4.A  |  08.09.2022 | Ich | Nutzer eine weitere Chance geben | 2x45 |
| 5.A  |  08.09.2022 | Ich | Falls richtig, fragen ob nochmals | 1x45 |
| 6.A  |  08.09.2022 | Ich | Ich kann das Programm wiederholen | 2x45 |
| 7.A  |  08.09.2022 | Ich | Ich kann die Versuche anzeigen lassen | 1x45 |
| 8.A  |  15.09.2022 | Ich | Das Programm muss einen Timer haben | 3x45 |
| 9.A  |  15.09.2022 | Ich | Random Letter programmieren | 3x45 |



Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden



## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  | 08.09.2022      |  Steven Salie         |   45'            |  10'                |
| 2.A  | 08.09.2022      |  Steven Salie         |   45'            |  10'                |
| 3.A  | 08.09.2022      |  Steven Salie         |   45'            |  10'                |
| 4.A  | 08.09.2022      |  Steven Salie         |   90'            |  10'                |
| 6.A  | 08.09.2022      |  Steven Salie         |   90'            |  10'                |
| 5.A  | 08.09.2022      |  Steven Salie         |   45'            |  10'                |
| 7.A  | 08.09.2022      |  Steven Salie         |   45'            |  10'                |





✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.

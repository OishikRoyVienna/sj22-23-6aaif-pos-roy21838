[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/toCQ-GGZ)
# Abgabenrepo in POS (6AAIF, 2022/23)

> **Name:** (Hier deinen Namen einfügen)  
> **Email:** (Hier deine Schul E-Mail einfügen)

Die Beurteilungsgrundlage für das 6. Semester ist die gelöste Probematura.
Du findest die Angabe in der Datei [Angabe.pdf](Angabe.pdf).
Das fertig eingerichtete Musterprojekt ist im Ordner *SPG_Fachtheorie*.
Öffne die Datei [SPG_Fachtheorie.sln](SPG_Fachtheorie/SPG_Fachtheorie.sln) mit Visual Studio 2022 oder Rider.

Hinweis: In der Maturaumgebung steht nur Visual Studio 2022 zur Verfügung!

## Arbeitsweise

Bearbeite die Aufgabenstellung in 3 Schritten.
Erstelle für jeden Schritt einen Feature Branch:

- 01-model
- 02-service
- 03-webapp

Wenn du mit einem Feature fertig bist, **erstelle einen pull request**.
Der Lehrer wird dann den pull request akzeptieren oder Änderungen anfordern.
**Committe niemals direkt in main.**

## Abgabe

Damit die Arbeit beurteilt werden kann, muss sie bis zur POS Stunde am Mi, den 21. Juni 2023 bearbeitet werden.

## Nützliche git Kommandos

### Integrieren der Änderungen von main in den feature branch

Prüfe mit `git branch`, ob du auch im richtigen Branch (also dem feature branch) bist.
Gib danach  
```
git pull origin main --rebase
```
in der Konsole ein, um die Änderungen in den feature branch zu ziehen.
Das ist nach einem erfolgreichen pull request nötig, bevor du mit dem nächsten feature branch weiterarbeitest.

Hinweise im Umgang mit git sind auf [https://github.com/schletz/pos3xhif#git](https://github.com/schletz/pos3xhif#git) zu finden.


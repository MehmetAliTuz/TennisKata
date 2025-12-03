\# Tennis Kata – Mehmet Ali Tuz



Dit project is mijn oplossing voor de Tennis Kata.

De bedoeling was om binnen een beperkte tijd de scorelogica van een tennismatch te implementeren en dit op een duidelijke en testbare manier te doen.

Ik heb hiervoor gewerkt met C# (.NET) en NUnit voor de unit tests.



\## Aanpak



Ik heb dit stap voor stap opgebouwd met TDD.  

Telkens:

1\. een test schrijven,

2\. laten falen,

3\. minimale code toevoegen om de test te laten slagen,

4\. en daarna kleine verbeteringen doen waar nodig.



Zo blijft de code overzichtelijk en voorspelbaar.



\## Structuur



Ik heb drie kleine onderdelen gemaakt:



\- \*\*Player\*\*: stelt een speler voor en houdt z’n punten bij.

\- \*\*ITennisGame\*\*: interface om het gedrag van de game vast te leggen.

\- \*\*TennisGame\*\*: de eigenlijke implementatie van de scorelogica.



De game heeft drie grote stukken logica:

\- normale scores (Love, Fifteen, Thirty, Forty),

\- gelijke scores (bv. Love-All, Thirty-All, Deuce),

\- eindfase (Advantage of Win).



\## Unit Tests



De tests vind je in `TennisKata.Tests`.  

Ik heb de belangrijkste scenario’s afgedekt:



\- Startscore: Love-All

\- Eerste punten voor speler 1 en speler 2

\- Deuce (3–3)

\- Advantage (bv. 4–3)

\- Win voor een speler


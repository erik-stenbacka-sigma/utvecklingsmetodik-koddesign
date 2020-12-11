# Övningsuppgifter för klassdiagram

Varje övning består av en textbeskrivning av en domän. Uppgiften är att översätta denna text till ett klassdiagram. Varje beskrivning har en egen sida i dokumentet och på sidan efter en beskrivning finns ett förslag på lösning. Kom ihåg att det finns mer än ett rätt svar när du ritar ett klassdiagram. Så bara för att din lösning inte ser exakt ut som den i dokumentet så behöver din lösning inte vara fel.

Beskrivningarna av domänerna som används i uppgifterna är inte kompletta om du jämför dem med verkligheten. Element och funktioner som är är vanliga i verkligheten har exkluderats från övningarna för att begränsa uppgiftens storlek.

<div style="page-break-after: always; visibility: hidden">
\pagebreak
</div>

## Övning 1

TODO

<div style="page-break-after: always; visibility: hidden">
\pagebreak
</div>

### Svar övning 1

TODO

<div style="page-break-after: always; visibility: hidden">
\pagebreak
</div>

## Övning 2

TODO

<div style="page-break-after: always; visibility: hidden">
\pagebreak
</div>

### Svar övning 2

TODO

<div style="page-break-after: always; visibility: hidden">
\pagebreak
</div>

# Övning 3

Domänen in den här uppgiften är ett flygbiljettbokningssystem. En kund ska kunna söka efter flights. När kunden hittat en flight hen vill åka med ska det också vara möjligt att boka en plats på flighten. Det gränssnitt som kunden använder för att boka sin plats är inte del av uppgiften. Det räcker att metoderna searchFlight(...) och bookFlight(...) finns med på någon/några klasser.

När kunden söker efter en flight ska en stad från vilken kunden vill resa anges. Kunden ska få en lista med möjliga flights tillbaka. Om en flight är fullbokad ska den inte vara med i listan. Listan ska vara sorterad efter destinationens betyg. På en flight ska det vara möjligt att se flight-nummer och vilket flygbolag flighten tillhör.

När kunden ska boka en plats på en flight anger hen vilken flight de vill åka med samt information om sig själv. Om bokningen går igenom får kunden en referens till bokningen som en bekräftelse. Bokningen kopplas även samman med den flight den här till.

Tips! Det är tillåtet att lägga till klasser i diagrammet som inte direkt omnämns i texten. Titta på de metoder som du lagt till i diagrammet och tänkt igenom vilken information du skulle behöva ha tillgång till för att implementera metoden.

<div style="page-break-after: always; visibility: hidden">
\pagebreak
</div>

# Svar övning 3

TODO

Kommentarer:
* Baserat på de krav som finns i beskrivningen kunde både Customer och Airline varit strängar istället för egna klasser i diagramet. De innehåller trots allt bara varit namn som är en sträng. Det är dock nästan alltid en god idé att skapa upp namngivna objekt för

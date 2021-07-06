# Integrationflow

XYZ vil gerne have opsat et integrationsflow fra JPNordic og indlæst data i XYZ database. Dataene skal benyttes til grundlag for hvornår XYZ skal konvertere valuta på deres platform. XYZ vil gerne have data hurtigst muligt efter dataene er offentliggjort.

JPNordic har offentliggjort dataene med et web-api. Disse data bliver opdateret en gang hver halve time.
Opgave:
Hvilke overvejelser er relevante i forhold til designet ud fra XYZ’s behov?
Lav en løsning I C# som henter data fra web api’et og indsætter det i SQL server databasen.

Overvejelser i forhold til XYZ's behov
   - Udfra testdataen kræver det ikke en særlig stor database, men der kan risikere at være det i virkeligheden, performance er derfor ikke en top prioritet men bør ikke spildes.
   - scheduelingen skal ikke nødvendigvis håndteres i koden
   - Der skal benyttes prepared statements(parameterisering)
   - Det er ikke forretningshemmelig information, hvilket gør dataen ikke kræver andet end alm. sikring under opbevaring og transit.
   - For at reducere angrebsflader bør programmet kun være åben i den tid det er nødvendigt.


beslutninger og ovejevejlser
   - Consol app kræver mindre end en standard web app opsætning og kan lukkes med det samme den er færdig
   - For at opdatere hver 30 min, giver det mere mening at registrere det til windows task scheduler, 
     eftersom det er hurtigere og kræver mindre vedligholdelse end at håndtere det i koden.
   - benytter en ORM til at udføre mere effektive forespørgsler og sikrer parameterisering.
    
Forbedringer
   - Connection stringen burde ikke være hardcoded men lagt ud i en config fil, således kunne der også bygges dependency injection
   - Context åbnes og lukkes mange gange med et foreach loop hvilket giver en dårligere performance, 
     det kunne være relevandt at gemme jsonfilen på serveren for at lave fil sammenligning, 
     og dermed undgå hele tiden at åbne og lukke forbindelser til databasen.

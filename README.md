# Prosjekt

## Hvordan man starter prosjektet

### Windows

1. kjører build.cmd
2. kjører startdb.cmd
3. Åpne terminalen og kjører "docker exec -it mariadb /bin/bash"
4. skriv apt-get update
5. skriv apt-get install mysql-client -y
6. dermed skriv exit
7. Skriv og kjør "docker exec -it mariadb mysql -p -uroot"
8. Skriv passord of da har man til gang for å danne database
9. Connect database i jetbrains med følge informasjon:
   1.Database=ProsjektDB
   2.Port=3308
11. Kjører dockerfile i jetbrains
12. Tilsutt kjør prosjekt i jetbrains


### Mac

1. kjører build.csh 
2. kjører startdb.sh
7. Skriv og kjør "docker exec -it mariadb mysql -p -uroot" i terminalen
8. Skriv passord of da har man til gang for å danne database
9. Connect database i jetbrains med følge informasjon:
   1.Database=ProsjektDB
   2.Port=3308
11. Kjører dockerfile i jetbrains
12. Tilsutt kjør prosjekt i jetbrains





# Applikasjonens oppsett (arkitektur) 

MVC er et designmønster brukt for å koble fra brukergrensesnittet (visning, eng. “View”), data (modell, eng. “Model”) og applikasjonslogikken (kontroller, eng. “Controller”). Dette mønsteret bidrar til å oppnå en separasjon av bekymringer. Ved å bruke MVC-mønsteret for nettsteder, blir forespørsler rutet til en kontroller som er ansvarlig for å samhandle med modellen for å utføre handlinger og/eller hente data. Kontrolleren velger visningen som skal vises og gir den modellen. Visningen gjengir den endelige siden basert på dataene i modellen. Applikasjonen bruker ‘Microsoft.AspNetCore.Mvc’ for å benytte ASP.NET Core MVC-rammeverket.

## Modell:
I MVC-arkitekturen representerer "Modell" applikasjonens data og forretningslogikk. Modellen er ansvarlig for å administrere data, behandle brukerinput og samhandle med databasen eller andre datakilder. Den inneholder kjernefunksjonaliteten og reglene for applikasjonen. Modellens viktigste ansvarsområder inkluderer datastyring, forretningslogikk, datavalidering, varsling om endringer og uavhengighet fra brukergrensesnittet. Modellen validerer data før de behandles eller lagres og sikrer at dataene oppfyller de nødvendige kriteriene. I mange MVC-implementeringer er modellen designet for å varsle visningen eller kontrolleren når dens interne tilstand endres, slik at visningen kan oppdatere seg selv som respons på endringer i dataene. Modellen er også uavhengig av brukergrensesnittet, noe som gir en mer vedlikeholdbar og skalerbar kode, ettersom endringer i brukergrensesnittet ikke direkte påvirker underliggende data eller forretningslogikk. Dette skiller og organiserer ansvarsområdene, og fremmer modularitet i programvareutvikling.

Det er 11 modeller i applikasjonen, hver med et spesifikt formål.

‘ChecklistViewModel’ fungerer som datastrukturen for håndtering av sjekklisteinformasjon i applikasjonen. Den omfatter ulike egenskaper som representerer detaljer knyttet til sjekklisten, inkludert dokumentidentifikasjon, personalinformasjon, datoer og spesifikke sjekker for ulike komponenter.

‘KontaktFormModel’ representerer datastrukturen for et kontaktskjema i applikasjonen. Den inneholder nødvendig informasjon for å håndtere brukerinputs knyttet til kontakt med systemet.

‘BrukerOversiktViewModel’ fungerer som datastrukturen for presentasjon av informasjon om ansatte i applikasjonen. Den inneholder nøkkelattributter som representerer detaljer om en ansatt, og muliggjør visning av relevant informasjon i brukergrensesnittet.

‘BrukerreistreringModel’ representerer datastrukturen for å legge til informasjon om ansatte i applikasjonen. Den inneholder egenskaper som lagrer detaljer om en ansatt, og forenkler prosessen med å legge til nye oppføringer i tabellen "Employee".

‘EquipmentViewModel’ fungerer som datastrukturen for å representere informasjon om utstyr i applikasjonen. Den inneholder egenskaper som lagrer detaljer om hvert stykke utstyr, og forenkler visning og administrasjon av utstyrsrelaterte data.

‘OversiktViewModel’ fungerer som datastrukturen for å presentere en oversikt over ulik informasjon i applikasjonen. Den inneholder egenskaper som lagrer detaljer om serviceordrer, kunder, garantier, produkter, samt spesifikke detaljer knyttet til serviceprosedyrer, hydrauliske, mekaniske og elektromodeller.

‘PartsViewModel’ fungerer som datastrukturen for å håndtere informasjon om deler i applikasjonen. Den inneholder egenskaper som lagrer detaljer om hver del, noe som forenkler sporing og visning av delrelaterte data.

‘FormViewModel’ fungerer som datastrukturen for håndtering av informasjon knyttet til serviceformularer i applikasjonen. Den inneholder egenskaper som lagrer detaljer om serviceordrer, brukte og erstattede deler, detaljer om serviceformularer og signaturer.

‘ServicesOrderViewModel’ fungerer som datastrukturen for å håndtere informasjon knyttet til serviceordrer og tilknyttede enheter i applikasjonen. Den inneholder egenskaper som lagrer detaljer om serviceordrer, kunder, garantier og produkter.

‘ArbeidsdokumentModelView’ fungerer som datastrukturen for å håndtere informasjon knyttet til arbeidsdokumenter i applikasjonen. Den inneholder egenskaper som lagrer detaljer om booket service, mottatte hendelser, serviceordrer, produkttyper, beskrivelser fra kunder, kundeinformasjon, avtalt levering, mottatte produkter, avtalt ferdigstillelse, ferdigstilling av service, timer brukt, og status for service-skjemaet.

‘ErrorViewModel’ fungerer som en datastruktur for håndtering og visning av feilinformasjon i applikasjonen. Den inneholder egenskaper relatert til feildetaljer og hjelper med å presentere brukervennlige feilmeldinger.

## Visning:
I den MVC-arkitektoniske modellen er Visning (eng. “View”) ansvarlig for å presentere data fra Modellen til brukeren og håndtere interaksjoner med brukergrensesnittet. View fokuserer på å vise informasjon, organisere elementer i brukergrensesnittet, formatere data for presentasjon, håndtere brukerinput og oppdatere seg selv som respons på endringer i Modellen. Den er uavhengig av forretningslogikken og kan ha flere perspektiver på de samme underliggende dataene. Denne separasjonen av ansvarsområder bidrar til økt modularitet og vedlikeholdsevne i applikasjonen

Applikasjonen inneholder en del visninger som er organisert inn i 14 mapper for hvert sitt formål. Visningene er av filtypen “.cshtml”, og er stylet ved bruk av hovedsakelig Bootstrap men også noe CSS for å spesifisere noen elementer. CSS filene er lokalisert i en egen mappe kalt css inn i mappen “wwwroot”.

## Kontroller:
I den MVC-modellen er Kontroller ansvarlig for å håndtere brukerinput, behandle forespørsler og koordinere kommunikasjonen mellom Modellen og Visningen. Den tolker brukerhandlinger, håndterer inndata, oppdaterer Modellen basert på brukerforespørsler og velger riktig Visning for å vise den endrede dataen. Kontrolleren spiller en sentral rolle i å opprettholde ansvarsseparasjonen i applikasjonen ved å holde brukergrensesnittslogikken og applikasjonslogikken uavhengige.

I applikasjonen har de 12 ulike kontrollerene ansvar for hvert sitt bruksområde i samheng med Modell og Visning. Kontrolleren har som oppgave å hente data fra Modell og vise Visningen. 


## Annet:
I tillegg til MVC, er det også brukt to ulike patterns som ikke går direkte i konflikt med databasen men som henter funksjonalitet. Det er blitt brukt “Repository Pattern” og “Unit of Work Pattern”.

“Repository Pattern” er et designmønster som skiller logikken som henter data fra applikasjonens database fra forretningslogikken i resten av programmet. I sammenheng med Entity Framework og ASP.NET MVC fungerer et repository som et mellomledd mellom datatilgangskoden (for eksempel Entity Framework) og resten av programmet. Det gir en sett med metoder for å utføre CRUD-operasjoner (Create, Read, Update, Delete) på dataenheter.

“Unit of Work Pattern” er et annet designmønster som jobber hånd i hånd med repository-mønsteret. Det sikrer at en logisk gruppe operasjoner behandles som en enkelt enhet, og enten blir alle operasjonene utført vellykket, eller ingen av dem blir det. I sammenheng med Entity Framework er en unit of work ofte assosiert med en transaksjon, og sikrer at endringer i databasen er atomære.

I denne applikasjonen, en ASP.NET MVC-applikasjon som bruker Entity Framework, hjelper disse mønstrene med å opprettholde en separasjon av bekymringer. Kontrolleren samhandler med et repository for å utføre datatilgangsoperasjoner, og repositoryet kommuniserer igjen med Entity Framework for å samhandle med databasen. Ved å implementere disse mønstrene blir det oppnådd en mer modulær og testbar arkitektur. Det gjør det også enklere å vedlikeholde og gjøre endringer i datatilgangslaget uten å påvirke resten av applikasjonen. 




# Hvordan applikasjonen kjøres (kjøring på Docker, kobling mot database, osv)

Det er flere gode grunner til hvorfor det er en fordel å bruke “Docker” i en slik sammensetning som dette. Docker bidrar til en enkel måte å kunne kjøre, teste og bygge en applikasjon. Ved hjelp av en omfattende “conteinerteknologi”, som legger alle applikasjoner i et tilsvarende container-miljø som inneholder alt en trenger for å kjøre applikasjonen. Det vil si, uavhengig av hvor forskjellige gruppens dataoppsett er, kan applikasjonen kjøres på samme måte uten problemer. 

MariaDB er et database-administrering-system som kan brukes til samtlige funksjoner, for eksempel lagring eller logging av data. I gruppens tilfelle ble det brukt til å opprette en database som inneholder relevant informasjon til systemets funksjonalitet. For at systemet skal kunne hente riktig informasjon fra databasen må koblingen være gjort korrekt. 

Gruppen har implementert noen “startup build" filer, for at programmet kan kjøre i en felles docker fil og koblet til databasen. Disse filene skal gjøre det enkelt kunne bygge og starte en Docker-container for både applikasjonen og databasen. 

For å koble opp til en docker container blir filen “build.sh” kjørt: 

Det første koden gjør er sjekke om en eksisterende container med navnet “webapp” kjører, dersom en slik container kjører blir den stoppet. Deretter blir det bygget et Docker-bilde ved å kjøre “docker image build”. Dette bygger et Docker-bilde fra gjeldende katalog med etiketten "webapp". Etter dette blir Docker-containeren startet fra det nylig bygde bildet, og gir den navnet "webapp". Det blir opprettet en kobling mellom verts-porten 80 til container-porten 80, mens docker blir kjørt i bakgrunnen. Brukeren blir tildelt en lenke til den lokale applikasjonen og pauser skriptet. 

For å kjøre applikasjonen i databasen blir filen “startDB.sh” kjørt: 

Skriptet kjører “docker run” som starter en MariaDB-container. Den kjører med en spesifikk tidssone, root-passord, og port-mapping hvor porten er 3308 på vertsmaskin og 3306 i containeren. For å sikre at MariaDB er initialisert og er klar til å godta tilkoblinger, venter den på MariaDB i 15 sekunder. Når den starter igjen blir Docker exec så brukt til å kjøre en GRANT-kommando i MariaDB-containeren for å tildele alle privilegier. Til slutt vises en melding om at MariaDB-containerne kjører og at privilegier er gitt.

Etter at begge filene er kjørt skrives og kjøres "docker exec -it mariadb mysql -p -uroot" i terminalen, passordet skrives inn og tilgangen til databasen er opprettet. Det nødvendig å opprette koblingen i det relevante IDEet, i gruppens tilfelle er dette “jetBrains”. Prosjektet heter “ProsjektDB” og porten som blir brukt er 3308. Til slutt kan prosjektet kjøres med databasen tilkoblet.



# Komponenter av applikasjonen (MVC, repo, klasser, osv)

Som sagt tidligere i forhold til MVC, så er Modell en representasjon av dataen knyttet til applikasjonen, hvorav de er ansvarlig for å administrere disse dataene. Visning skal presentere dataene fra Modellen, og Kontroller skal håndtere kommunikasjon mellom Modell og Visning, samt brukerinput og forespørsler.

For eksempel, så har man Visningen “Arbeidsdokument”, og for at brukeren skal kunne se dataene på denne siden, så må Kontrolleren, “ArbeidsdokumentController” hente dataene fra Modellen, “ArbeidsdokumentModelView”, og deretter sende det til Visningen, slik at det blir presentert for brukeren.

I tilknytting med applikasjonen, så blir CRUD-operasjoner (Create, Read, Update, Delete) utført i isolasjon fra resten av applikasjonen. Med Repository Pattern så blir disse metodene definert til å bli utført for vanlige databaseoperasjoner. 



Bildet ovenfor er et eksempel på Create-operasjon i “AddEquipment”-metoden. HTTP POST-metoden tar inn data fra et “AddEquipmentModel”-objekt. Mens den gjør det, så sjekker den om det allerede eksisterer et utstyrs-objekt med det samme navnet ved å kalle ‘_equipmentRepository.getEquipmentByName(model.Name_str)’. Dersom objektet ikke eksisterer, så oppretter den et nytt “EquipmentModel”-objekt basert på modellen og bestemmer tilgjengeligheten basert på ‘model.Availability’, og deretter legger til dette utstyret i databasen ved å kalle ‘_equipmentRepository.InsertEquipment(EquipmentObj).



Bildet over viser til en Read-operasjon i metoden “Employees”. metoden henter alle brukerne fra ‘_employeeRepository’ og deretter oppretter en liste av objektene i ‘BrukerOversiktViewModel’ for å representere informasjonen til brukerne. I tillegg, for hver bruker i ‘employeeList’, utføres det Read-operasjonen ved å opprette et ‘BrukerOversiktViewModel’-objekt og legger det til i listen. Resultatet av dette sendes da til visning i “Employees”. 



Bildet ovenfor viser en Update-operasjon i “UpdateEmployee”-metoden. Metoden tar inn data fra et ‘EmployeeUpdateModel’-objekt og oppdaterer en eksisterende bruker i databasen med de nye dataene. For å utføre denne oppdateringen, så blir det brukt ‘_employeeRepository’-metoder som ‘getUserByEmail’, ‘updateUserRole’ og ‘updateUser’. Brukeren blir deretter omdirigert tilbake til “Employee”-siden etter oppdateringen av informasjonen har gått gjennom.



Et relativt enkelt eksempel på en Delete-operasjon blir vist i bildet over, hvor ‘RemoveEmployee’-metoden tar inn data fra ‘BrukerOversiktViewModel’ og bruker en ‘_employeeRepository’-metode, ‘DeleteUser’ for å slette en bruker fra databasen. Deretter blir brukeren omdirigert tilbake til “Employee”-siden.

De viktigste klassene i applikasjonen er så å si knyttet til hverandre, hvorav en hver klasse er tett knyttet til en annen, for håndtering av data. For eksempel, representerer “Customer” og “Postal_Code” informasjonen om kunden, og er sentral for håndteringen av kundeinformasjon i sammenheng med serviceordre.

For applikasjonen som Nøsted har bedt om, så er det klassene “Service_Order”, “Service_Form”, “Service_Order_Service_form”, “Service_Form_Employee” og “Service_Form_Sign” som knyttes sammen og er blant de viktigste. Disse klassene i helhet sørger for å holde serviceordrer oppdatert, notere ansatte sin arbeidstid på servicen, og holder styr på skjemaer og signaturer knyttet til serviceordren. Her blir “Service_Order” ansett som superklassen.

“Checklist” og “Checklist_signature” sikrer kvalitetskontroller, hvor “Checklist”-klassen holder informasjonen som må bli fylt ut, og derfor blir identifisert som superklassen, og “Checklist_signature” tar hånd om signaturene knyttet til sjekklistene. 

I denne applikasjonen, så er det enkelt å si én klasse som dekker en spesifikk funksjonalitet i systemet er det viktigste, men det som blir oversett da er de andre underklassene som er med på å gjøre dataen som blir lagt inn fullstendig og forståelig. 


# Funksjonaliteter i applikasjonen (det som applikasjonen gjør)

Hensikten med applikasjonene er å gi Nøsted & et system som registrere, mottar og behandler serviceordre. Formålet er å gjøre nåværende arbeidsrutiner digitalisert for å gjøre hverdagen deres enklere og mer effektiv. Med å gjøre systemet digital, vil det gi mange positive innvirkninger, et av de er at digitalisering løser problemet med at i nåværende situasjon er enkelte prosesser repeterende. Dette har gruppen løst med å innføre automatiserte prosesser. 
Funksjonaliteter: 
-       Automatisk oppdatering på enkelte deler av systemet. Eksempel bruker oversikt siden nettopp dette. Når man oppretter en serviceordre, vil da informasjonen på den automatisk bli fylt inn i oversiktssiden. Samme med serviceskjema og sjekkliste.  Arbeidsdokument er et annet eksempel på automatisering. Arbeidsdokumentet blir oppdatert automatisk når en ordre blir lagt inn. Dette er for at alle ansatte har samme oversikt over serviceordre som er aktive. 
-       Automatisering skjer også i databasen. Når en serviceordre og serviceskjema blir opprettet, genererer den automatisk et unikt id for skjemaene. Med å innføre dette så løser man prosessen som var tidligere repeterende når administrator måtte være den som lagde disse unike id manuelt.  
-       Legge til, endre eller slette data. Dette blir brukt på sidene “brukeroversikt” og “deler”. 



# Logikken av applikasjonen (koden)

Teknologisk Oversikt
Programmeringsspråk: C#
Frontend Teknologier: HTML, CSS, JavaScript
Backend Rammeverk: ASP.NET Core
ORM (Object-Relational Mapping): Entity Framework Core
Databaseteknologi: MariaDB, administrert via Docker.
Sikkerhet: Implementering av ASP.NET Core Identity for autentisering og autorisasjon, samt bruk av anti-forgery tokens.

MVC Arkitektur

Modell: Definert i C# klasser. 



Visning: Razor CSHTML.



Kontroller: Håndterer bruker forespørsler, samhandler med modeller og returnerer visninger. 

Database Interaksjon






Kontrolleren bruker _context for å hente data fra databasen, og denne dataen blir passert til visningene (views) for å generere den endelige HTML som brukeren ser.

“OnModelCreating” definerer og skal konfigurere modeller og deres relasjoner i databasen.




Autentisering og Sikkerhet
ASP.NET Core Identity. Tilbyr autentisering og autorisasjon funksjonalitet. Håndtering med brukere, dets registrering, innlogging, og tilgangskontroll.
Anti-forgery tokens har blitt integrert i forskjellige steder som razor CSHTML eller i controller for å forhindre CSRF-angrep.


Migrasjoner
Det gjør det mulig å oppdatere databasen slik at det reflekteres i modellen gjennom å kjøre kommandoen i terminalen: 
dotnet ef migrations add 
InitialCreated dotnet ef database update


# Unit testing scenarier type tester f. eks. UI test (test kode/skripter og resultater)
Trenger ikke unit testing på FAQ. 

## Test scenarioer: 
Gruppen testet scenario på ung alder målgruppe. Denne målgruppen har noen dataerfaring fra før av.  

### Oppgave: Serviceordre
Beskrivelse: Opprette serviceordre
Instruksjoner:
   - Logg inn.
   - Trykk på meny knapp oppe til høyre.
   - Velg “Oversikt”.
   - Trykk på “Serviceordre”. 
   - Fyll inn informasjon om kunde og produkt. 
   - Trykk på “send inn”.
   - Serviceordre blir presentert på oversiktsiden. 
Forventet resultat:
   - Etter trykt på send inn, blir man sendt tilbake til oversiktsiden, og kan se at det har kommet inn en ny ordre. 
Faktisk resultat: 
   - Etter trykt på “Send inn”, ble man sendt tilbake til serviceordre siden 



### Oppgave: Serviceskjema
Beskrivelse: Opprette serviceskjema
Instruksjoner:
   - Logg inn.
   - Trykk på meny knapp oppe til høyre.
   - Velg “Oversikt”.
   - Trykk på “Serviceskjema”. 
   - Skriv ordrenummeret fra en tidligere opprettet serviceordre. 
   - Fyll inn informasjon om service ut ifra serviceordre. 
   - Trykk på send inn.
Forventet resultat:
   - Etter trykt på send inn, og fylt inn eventuelle deler som har blitt brukt, kom man tilbake til oversiktsiden og ser at det har blitt lagt inn      id til skjemaet med serviceordren.  
Faktisk resultat:
   - Etter trykt på send inn, og fylt inn eventuelle deler som har blitt brukt, kom man til en hvit siden. Service Skjemaet ble lagret i oversikt       selv om man ikke kom til riktig side. 


### Oppgave: Sjekkliste 
Beskrivelse: Opprette sjekkliste
Instruksjoner:
   - Velg “Oversikt” i meny.
   - Trykk på “Sjekkliste”. 
   - Fyll ut generell informasjon.
   - Trykk på neste.  
   - Trykk på sjekk boksene ut ifra fullført arbeid ut ifra  hvilken avdeling man hører til.
   - Signer og send inn. 
Forventet resultat:
   - Etter trykket på send inn, vil man komme tilbake til oversiktsiden og se at sjekklisten har blitt lagt til på ordren. 
Faktisk resultat: 
   - Etter tykt på send inn, ble man ikke sendt tilbake til oversikt. Sjekkliste var ikke koblet til og dermed ikke oppdatert på oversiktsiden 


### Oppgave: Deler
Beskrivelse: Legge til/ endre og slette deler.  
Instruksjoner:
   - Legg til nytt deler: 
         - Velg “Deler” fra meny.
         - Trykk på “Legg til” knapp.
         - Skriv inn nødvendig info. 
         - Trykk på “Lagre”. 
   - Endre antall deler: 
         - Velg “Deler” fra meny.
         - Trykk på tannhjul knapp ved siden av ønsket deler å endre.
         - Skriv inn nødvendig info. 
         - Trykk på “Oppdater”. 
   - Slett deler: 
         - Velg “Deler” fra meny.
         - Trykk på knappen “Slett”
         - Skriv inn ID og trykk slett igjen. 
Forventet resultat:
   - Når man har lagt til, endret eller slettet vil man kunne se resultatet med engang på tabellen med Deler. 
Faktisk resultat:
   - Resultatet ble som forventet resultat. 


### Oppgave: Utstyr 
Beskrivelse: Legge inn og slette deler på utstyr. 
Instruksjoner:
   - Legg til nytt utstyr: 
         - Velg “Utstyr” fra meny.
         - Trykk på “Legg til” knapp.
         - Skriv inn nødvendig info. 
         - Trykk på “Lagre”. 
   - Slett utstyr: 
         - Velg “Utstyr” fra meny.
         - Trykk på knappen “Slett”
         - Skriv inn ID og trykk slett igjen. 
Forventet resultat:
   - Når man har lagt til eller slettet vil man kunne se resultatet med engang på tabellen med utstyr. 
Faktisk resultat: 
   - Resultatet ble som forventet resultat. 


### Oppgave: Brukeroversikt
Beskrivelse: Legge inn, endre og slette en bruker. 
Instruksjoner:
   - Legge til ny bruker: 
         - Velg “Brukeroversikt” i meny.
         - Trykk på knappen “Legg til bruker”.
         - Fyll inn informasjon om brukeren.
         - Trykk på “Registrer” for å registrere ordren. 
         - Den nyansatte vil da komme opp på brukeroversikt. 
   - Slette bruker: 
         - Velg “Brukeroversikt” i meny.
         - Trykk på tannhjul knappen som er ved siden av hver ansatt.
         - Velg “slett” på den ønsket bruker .
         - Ansatte vil da bli slettet fra systemet. 
   - Endre bruker: 
         - Velg “Brukeroversikt” i meny.
         - Trykk på tannhjul knappen som er ved siden av hver ansatt.
         - Fyll ut ønsket data som skal endres.
         - Trykk på “oppdater” for å oppdatere ansatte. 
Forventet resultat:
   - Når man har lagt til, endret eller slettet bruker vil man kunne se resultatet med engang på tabellen med brukeroversikt. 
     Hvis man skal søke etter en spesifikk bruker kan man bruke søke baren til å finne enkelt frem til hvilken som helst bruker.
Faktisk resultat: 
   - Resultatet ble som forventet resultat med at man kunne slette, endre og opprette ny bruker. Det som ikke fungerte som forventet er sidebaren.      Det gikk ikke å søke etter bruker. 



# Hvordan applikasjonen brukes (brukesanvisning)

Alle ansatte må logge seg inn med sin bruker, de vil da få tilgang til siden og det de har adgang til. For å navigere seg gjennom sidene brukes hamburger meny knappen oppe til høyre. 

## Administrator/kundebehandler: 
administrator kan opprette serviceordre, legge til på  deler, slette, endre og opprettet bruker.

### Opprette serviceordre: 
Velg “Oversikt” i meny.
Trykk på knappen “Serviceordre”.
Fyll inn informasjon om kunde og produkt.
Trykk på send inn for å registrere ordren. 
Velg oversikt igjen for å se de nye ordene. 

### Legge til ny bruker: 
Velg “Brukeroversikt” i meny.
Trykk på knappen “Legg til bruker”.
Fyll inn informasjon om brukeren.
Trykk på “Registrer” for å registrere ordren. 
Den nyansatte vil da komme opp på brukeroversikt. 

### Slette bruker: 
Velg “Brukeroversikt” i meny.
Trykk på tannhjul knappen som er ved siden av hver ansatt.
Velg “slett” på den ønsket bruker .
Ansatte vil da bli slettet fra systemet. 

### Endre bruker: 
Velg “Brukeroversikt” i meny.
Trykk på tannhjul knappen som er ved siden av hver ansatt.
Fyll ut ønsket data som skal endres.
Trykk på “oppdater” for å oppdatere ansatte. 

### Legg til nytt deler: 
Velg “Deler” fra meny.
Trykk på “Legg til” knapp.
Skriv inn nødvendig info. 
Trykk på “Lagre”. 

### Endre antall deler: 
Velg “Deler” fra meny.
Trykk på tannhjul knapp ved siden av ønsket deler å endre.
Skriv inn nødvendig info. 
Trykk på “Oppdater”. 


### Slett deler: 
Velg “Deler” fra meny.
Trykk på knappen “Slett”
Skriv inn ID og trykk slett igjen. 

## Reparatør: 
Repreatørene kan fylle ut serviceskjema, sjekkliste, utstyr. 

### Opprette serviceskjema:
Velg “Oversikt” i meny.
Trykk på “Serviceskjema”. 
Skriv ordrenummeret fra en tidligere opprettet serviceordre. 
Fyll inn informasjon om service ut i fra serviceordre. 
Trykk på send inn.

Reparatørene har tre avdelinger i seg, det er mekanisk, hydraulisk og elektro. sjekklisten er delt opp i tre deler der hver av disse avdelingene kan fylle ut sin del uten å fylle på de andres deler. 
### Opprette sjekkliste:
Velg “Oversikt” i meny.
Trykk på “Sjekkliste”. 
Fyll ut generell informasjon.
Trykk på neste.  
Trykk på sjekk boksene ut ifra fullført arbeid ut ifra  hvilken avdeling man hører til.
Signer og send inn. 

### Legg til nytt utstyr: 
Velg “Utstyr” fra meny.
Trykk på “Legg til” knapp.
Skriv inn nødvendig info. 
Trykk på “Lagre”. 

### Slett utstyr: 
Velg “Utstyr” fra meny.
Trykk på knappen “Slett”
Skriv inn ID og trykk slett igjen. 


### Endringer i koden (hva er det som ble endret, av hvem og når)

Par-koding/programmering var et konsept som gruppen forsøkte å ta inn under utviklingen av applikasjonen. Dette var blant annet fordi par-koding er til stor fordel for begge partene, ettersom det er mye læring i metoden. Men gruppen fant raskt ut av at dette ikke var den beste metoden i starten, siden det var begrenset med kunnskap hos de fleste gruppemedlemmene. Det var derfor enklere å heller ha det ene gruppemedlemmet med den nødvendige erfaringen å “lære” de andre på gruppen, og heller hjelpe dem som en gruppe og noen ganger individuelt ved spesifikke feil eller problemer som oppstod. Med opplæring i koding og hvordan man holder GitHub repository hygienen ren, så ble utviklingen av applikasjonen mye mer effektiv. Selv om, det var til tider situasjoner hvor par-koding ble tatt i bruk likevel, som er derfor det i blant er noen brukere som har flere commits enn andre, hvorav noen brukere har kun noen få commits. 

Måten gruppen har valgt å dokumentere endringer i koden, er ved å observere gruppens GitHub aktivitet. Hvert gruppemedlem måtte pushe og legge inn en pull request på de siste endringene de gjorde for å fremme en aktiv og stadig oppdatert GitHub repository. Gruppen har også gjort det slik at enhver pull request må bli godkjent og sett gjennom av et annet gruppemedlem. Ved å gjøre det slik, og ved å se tilbake på de lukkede pull request-ene og tidligere committene, så vet hvert medlem hva som har blitt endret på, når endringen ble gjort, og hva som eventuelt ble lagt til. Ved problemer/feil eller oppdagelse av bugs, så ble dette tatt i plenum under det daglige Scrum møtet, eller skrevet inn på GitHub under Git Issues. Med bruk av Issues, så ble det enklere for gruppen å se hvilke aktive problemer som måtte fikses, og det ga en mer intuitiv måte å legge inn problemer som oppstod utenfor Scrum møtene.






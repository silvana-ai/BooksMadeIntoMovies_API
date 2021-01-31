

^****BooksMadeInToMoves-API****

I build my project with ASP.Net EntytiFramework Web Application and comentController
On this project can a client choose a book from list of books and then the client can se the description of books,Name,Id,Imdblad(classer).
on Book controler we have tow API :

* [HttpGet("all")] Asynkron metod för att hämta alla böcker från databasen och det ingår felhäntering (try/catch) ifall books inte finns.

*[HttpGet("details/{id}")]Asynkron metod för att hämta en book med id från databasen och det ingår felhäntering (try/catch) ifall book med id inte finns.

Man kan liggar mer eller complletera Controler om man vill som : Delete en book eller put/update ,eller Add.

Vi har användat i BooksControler Dependency Injecton för att inject context i databas.

För att fungera programet på annat dator när man ladar ner den måste man andra på "ConnectionStrings" som finns i (appsittings.jason) till den SQLserver som finns i data och add migration ,update migration.


using System.Security.Cryptography.X509Certificates;

namespace HttpClient_oppgave;

class Program
{
    static async Task Main(string[] args)
    {

        FileMethod fileMethod = new FileMethod();
        // Lager et HttpClient-objekt, som kan sende forespørsler til servere. 

        HttpClient client = new HttpClient();

        // Sender en Get-forespørsel til endepunktet som er levert til GetAsync-metoden.
        // Returnerer en HttpResponseMessage, med både statuskode og dataen på endepunktet.


        
        HttpResponseMessage response = await client.GetAsync("https://www.thecocktaildb.com/api/json/v1/1/filter.php?i=Gin");

        string content = await response.Content.ReadAsStringAsync();
        
        
       // Console.WriteLine(content);

        // Jeg prøvde å bruke WriteToFile-metoden fra forelesningen, men den ga meg en feilmelding om at prosessen var opptatt (?).
        // Derfor valgte jeg å bare skrive filen direkte med den innebygde metoden i File-klassen. Det blir litt mindre sikkert, men det fungerer
        // i denne sammenhengen.


        File.WriteAllText("gin_cocktails.json", content);



    }

        



    }   


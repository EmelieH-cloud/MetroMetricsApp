using MetroMetricsApp.Modeller;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace MetroMetricsApp.Databas
{
    public class DatabaseHelper
    {
        private readonly MyDbContext dbContext;

        public DatabaseHelper()
        {
            this.dbContext = new MyDbContext();
        }

        public async Task PrintMostNorthernCityInCanadaAsync()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            var mostNorthernCity = await dbContext.Cities
                .Where(city => city.Country.Name == "Canada")
                .OrderByDescending(city => city.Latitude)
                .FirstOrDefaultAsync();

            if (mostNorthernCity != null)
            {
                Console.WriteLine($"Most Northern City in Canada: {mostNorthernCity.Name}");
                CreateTransaction(DateTime.Now, stopwatch.ElapsedMilliseconds, "6. Nordligaste staden i kanada.");
            }
            else
            {
                Console.WriteLine("No city found in Canada.");
            }
        }

        public async Task PrintChileAsync()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            var chile = await dbContext.Countries
                .Where(country => country.Name == "Chile")
                .FirstOrDefaultAsync();

            if (chile != null)
            {
                Console.WriteLine($"Country Name: {chile.Name}");
                stopwatch.Stop();
                CreateTransaction(DateTime.Now, stopwatch.ElapsedMilliseconds, "Printa Chile INNAN indexering.");
            }
            else
            {
                Console.WriteLine("Chile not found.");
            }
        }


        public void CreateTransaction(DateTime timestamp, long duration, string assignment)
        {
            Transaction transaction = new()
            {
                Timestamp = DateTime.Now,
                DurationInMs = duration,
                Assignment = assignment
            };
            dbContext.Transactions.Add(transaction);
            dbContext.SaveChanges();
        }

        public async Task PrintNaganoAsync()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var naganoCity = await dbContext.Cities
                .Where(city => city.Name.Equals("Nagano"))
                .FirstOrDefaultAsync();

            if (naganoCity != null)
            {
                stopwatch.Stop();
                CreateTransaction(DateTime.Now, stopwatch.ElapsedMilliseconds, "2. Hämta Nagano");
                Console.WriteLine($"Hittade staden {naganoCity.Name}.");
            }
            else
            {
                Console.WriteLine("Nagano hittades inte.");
            }
        }

        public async Task GetCitiesInBrazilAsync()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var citiesInBrazil = await dbContext.Cities
               .Where(city => city.Country.Name == "Brazil")
               .ToListAsync();

            foreach (City city in citiesInBrazil)
            {
                Console.WriteLine(city.Name);
            }
            stopwatch.Stop();
            CreateTransaction(DateTime.Now, stopwatch.ElapsedMilliseconds, "3. Hämta Brasiliens alla städer.");

        }

        public async Task GetCitiesInBrazilAsync2()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var brazil = await dbContext.Countries
             .Where(country => country.Name == "Brazil")
             .FirstOrDefaultAsync();

            var citiesInBrazil = await dbContext.Cities
               .Where(city => city.Country.Name == "Brazil")
               .ToListAsync();

            foreach (City city in citiesInBrazil)
            {
                Console.WriteLine(city.Name);
            }

            Console.WriteLine($"Namn: {brazil.Name}, Tidszon: {brazil.Timezone}," +
           $" Nummerkod: {brazil.NumericCode}, Huvudstad: {brazil.Capital}, Landskod: {brazil.CountryId}," +
           $" Nationalitet: {brazil.Nationality}, Valutanamn: {brazil.CurrencyName}, Valuta: {brazil.Currency}," +
           $" Riktnummer: {brazil.PhoneCode}");

            stopwatch.Stop();
            CreateTransaction(DateTime.Now, stopwatch.ElapsedMilliseconds, "3. Hämta Brasiliens alla städer + relaterad data.");

        }


        public async Task PrintCapitalCitiesWithEuroCurrencyAsync()
        {
            Stopwatch stopwatch = new();
            stopwatch.Start();
            var euroCountries = await dbContext.Countries
           .Where(country => country.Currency == "EUR")
           .ToListAsync();

            foreach (var country in euroCountries)
            {
                var capitalCity = await dbContext.Cities
                    .Where(city => city.Name == country.Capital)
                    .FirstOrDefaultAsync();

                if (capitalCity != null)
                {
                    Console.WriteLine($"Country: {country.Name}, Capital City: {capitalCity.Name}");
                }
            }
            stopwatch.Stop();
            CreateTransaction(DateTime.Now, stopwatch.ElapsedMilliseconds, "5. Printa alla huvudstäder med EUR i valuta");

        }

        public async Task GetCapitalCityOfJapanAsync()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var japan = await dbContext.Countries
                .Where(country => country.Name == "Japan")
                .FirstOrDefaultAsync();

            if (japan != null)
            {
                var capitalCity = await dbContext.Cities
                    .Where(city => city.Name == japan.Capital)
                    .FirstOrDefaultAsync();

                if (capitalCity != null)
                {
                    stopwatch.Stop();
                    CreateTransaction(DateTime.Now, stopwatch.ElapsedMilliseconds, "1. Hämta Japans huvudstad.");
                    Console.WriteLine($"The capital city of Japan is {capitalCity.Name}.");
                }
            }

        }

    }

}
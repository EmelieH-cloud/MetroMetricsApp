// See https://aka.ms/new-console-template for more information

using MetroMetricsApp.Databas;

class Program
{
    static async Task Main(string[] args)
    {

        DatabaseHelper dbHelper = new DatabaseHelper();

        // 1. Hämta Japans huvudstad
        // await dbHelper.GetCapitalCityOfJapanAsync();

        // 2. Hämta Nagano
        // await dbHelper.PrintNaganoAsync();

        // 3. Printa alla Brasiliens städer 
        // await dbHelper.GetCitiesInBrazilAsync();

        // 4. Printa alla Brasiliens städer + relaterad data
        // await dbHelper.GetCitiesInBrazilAsync2();

        // 5. Printa alla huvudstäder med EUR som valuta. 
        // await dbHelper.PrintCapitalCitiesWithEuroCurrencyAsync();

        // 6. Printa den nordligaste staden i kanada. 
        // await dbHelper.PrintMostNorthernCityInCanadaAsync();

        // Printa Chile innan indexering.
        // await dbHelper.PrintChileAsync();
    }
}
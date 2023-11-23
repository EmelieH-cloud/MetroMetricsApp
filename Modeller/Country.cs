using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetroMetricsApp.Modeller
{
    public class Country
    {
        [Key]
        // Unik identifierare 
        [Column("id")]
        public int CountryId { get; set; }

        // Landets namn
        [Column("name")]
        public string? Name { get; set; }

        // Landskod
        [Column("numeric_code")]
        public int NumericCode { get; set; }

        // Landets riktnummer
        [Column("phone_code")]
        public string? PhoneCode { get; set; }

        // Namnet på landets huvudstad
        [Column("capital")]
        public string? Capital { get; set; }

        // Valutakod
        [Column("currency")]
        public string? Currency { get; set; }

        // Namnet på landets valuta 
        [Column("currency_name")]
        public string? CurrencyName { get; set; }

        // Namn på nationalitet 
        [Column("nationality")]
        public string? Nationality { get; set; }

        // Lista över landets städer 
        [NotMapped]
        public List<City> Cities { get; set; } = new();

        [NotMapped]
        public TimeZoneInfo Timezone { get; set; } = null!;


        [Column("timezones")]
        public string? TimezoneJson { get; set; }


    }
}
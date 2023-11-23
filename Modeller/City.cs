using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetroMetricsApp.Modeller
{
    public class City
    {
        // Unik identifierare
        [Key]
        [Column("id")]
        public int CityId { get; set; }

        // Stadens namn
        [Column("name")]
        public string Name { get; set; } = null!;

        // Referens till landets ID (FK)
        [ForeignKey("Country")]
        [Column("country_id")]
        public int CountryId { get; set; }

        // Navigation property till landet 
        public Country Country { get; set; } = null!;

        // Latitude
        [Column("latitude")]
        public decimal Latitude { get; set; }

        // Longitude
        [Column("longitude")]
        public decimal Longitude { get; set; }
    }
}
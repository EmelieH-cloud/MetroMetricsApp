using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetroMetricsApp.Modeller
{
    public class Transaction
    {
        // Unik identifierare
        [Key]
        [Column("transaction_id")]
        public int TransactionId { get; set; }

        // Tidsstämpel för transaktionen
        [Column("timestamp")]
        public DateTime Timestamp { get; set; }

        // Varaktighet för transaktionen i millisekunder
        [Column("duration_ms")]
        public long DurationInMs { get; set; }

        [Column("assignment")]
        public string? Assignment { get; set; }
    }
}
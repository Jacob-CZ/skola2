using Supabase.Postgrest.Attributes;

namespace Supabase.Postgrest.Models
{
    [Table("loans")]
    public class Loan : BaseModel
    {
        [PrimaryKey("id")]
        public int Id { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("car")]
        public long Car { get; set; }
        [Column("customer")]
        public long Customer { get; set; }
        [Column("loan_date")]
        public DateOnly LoanDate { get; set; }
        [Column("return_date")]
        public DateOnly ReturnDate { get; set; }
    }
}

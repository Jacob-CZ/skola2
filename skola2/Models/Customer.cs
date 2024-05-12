
using Supabase.Postgrest.Attributes;

namespace Supabase.Postgrest.Models
{
    [Table("customers")]
    public class Customer : BaseModel
    {
        [PrimaryKey("id")]
        public int Id { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set;}
        [Column("name")]
        public string Name { get; set; }
        [Column("surname")]
        public string Surname { get; set; }
        [Column("birth_date")]
        public DateOnly BirthDate { get; set; }
        [Column("phone")]
        public int Phone { get; set; }
    }
}

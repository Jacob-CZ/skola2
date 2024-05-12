using Supabase.Postgrest.Attributes;

namespace Supabase.Postgrest.Models
{
    [Table("canvas")]
    public class Canvas : BaseModel
    {
        [PrimaryKey("id")]
        public long Id { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; } 

    }
}

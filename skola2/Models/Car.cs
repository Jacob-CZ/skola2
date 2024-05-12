namespace Supabase.Postgrest.Models
{
    using Supabase.Postgrest.Attributes;

    [Table("cars")]
    class Car : BaseModel
    {
        [PrimaryKey("id", false)]
        public long Id { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("vin")]
        public long Vin { get; set; }

        [Column("plate")]
        public string Plate { get; set; }

        [Column("make")]
        public string Make { get; set; }

        [Column("model")]
        public string Model { get; set; }

        [Column("year")]
        public DateTime Year { get; set; }

        [Column("price")]
        public short Price { get; set; }

        [Column("avilable")]
        public bool Available { get; set; }

        [Column("odometr")]
        public long Odometer { get; set; }

        [Column("no_of_seats")]
        public int NumberOfSeats { get; set; }
    }

}

using System.ComponentModel.DataAnnotations.Schema;

namespace ClothingShop.Domain.Entities
{
    [Table("cloth")]
    public class Cloth
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("name")]
        public string Name { get; set; } = string.Empty;

        [Column("description")]
        public string? Description { get; set; } = string.Empty;

        [Column("quantity")]
        public int Quantity { get; set; }

        [Column("color")]
        public string Color { get; set; } = string.Empty;

        [Column("size")]
        public int Size { get; set; }
    }
}

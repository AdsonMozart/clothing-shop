using System.ComponentModel.DataAnnotations.Schema;

namespace ClothingShop.Communication.Requests
{
    public class RequestCloth
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public string Color { get; set; } = string.Empty;
        public int Size { get; set; }
    }
}

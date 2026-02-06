namespace ClothingShop.Communication.Responses
{
    public class ResponseCloth
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public string Color { get; set; } = string.Empty;
        public int Size { get; set; }
    }
}

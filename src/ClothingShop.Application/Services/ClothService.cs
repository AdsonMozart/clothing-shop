using ClothingShop.Communication.Requests;
using ClothingShop.Communication.Responses;

namespace ClothingShop.Application.Services
{
    public class ClothService
    {
        public async Task<ResponseCloth> Register(RequestCloth request)
        {
            return new ResponseCloth()
            {
                Name = request.Name,
                Description = request.Description,
                Color = request.Color,
                Quantity = request.Quantity,
                Size = request.Size
            };
        }

        public async Task<ResponseClothes> GetAll()
        {
            return new ResponseClothes()
            {
                Clothes = new List<ResponseCloth>()
                {
                    new ResponseCloth
                    {
                        Id = Guid.NewGuid(),
                        Name = "Camisa",
                        Description = "123",
                        Color = "Azul",
                        Quantity = 2,
                        Size = 30
                    }
                }
            };
        }
    }
}

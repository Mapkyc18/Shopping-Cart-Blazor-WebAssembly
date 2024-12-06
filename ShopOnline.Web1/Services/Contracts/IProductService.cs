using ShopOnline.Models.Dtos;

namespace ShopOnline.Web1.Services.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetItems();
        Task<ProductDto> GetItem(int id);
    }
}

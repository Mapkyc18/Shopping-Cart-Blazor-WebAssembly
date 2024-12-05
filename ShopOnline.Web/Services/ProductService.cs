using ShopOnline.Web.Services.Contracts;
using System.Net.Http.Json;
using ShopOnline.Models.Dtos;

namespace ShopOnline.Web.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient httpClient;

        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<ProductDto>> GetItems()
        {
            try
            {
                var response = await httpClient.GetFromJsonAsync<IEnumerable<ProductDto>>("api/Product");
                return products;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}

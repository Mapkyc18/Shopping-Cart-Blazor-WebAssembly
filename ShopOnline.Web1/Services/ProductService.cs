﻿using ShopOnline.Models.Dtos;
using ShopOnline.Web1.Services.Contracts;
using System.Net.Http.Json;
using ShopOnline.Models.Dtos;
using ShopOnline.Web1.Components.Pages;

namespace ShopOnline.Web1.Services
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
                var products = await httpClient.GetFromJsonAsync<IEnumerable<ProductDto>>("api/Product");
                return products;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
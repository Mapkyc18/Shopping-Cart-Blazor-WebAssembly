using Microsoft.AspNetCore.Components;
using ShopOnline.Models.Dtos;


namespace ShopOnline.Web1.Components.Pages
{
    public class DisplayProductsBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<ProductDto> Products { get; set; }

    }
}

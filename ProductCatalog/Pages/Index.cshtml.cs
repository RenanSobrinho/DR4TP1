using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProductCatalog.Pages;

public class IndexModel : PageModel
{
    public List<Product> Products { get; } = new()
    {
        new Product("Teclado", 149.90m),
        new Product("Mouse", 79.90m),
        new Product("Monitor", 899.00m)
    };

    public void OnGet()
    {
    }
}

public record Product(string Name, decimal Price);

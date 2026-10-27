using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProductCatalog.Pages;

public class AddProductModel : PageModel
{
    [BindProperty]
    [Required(ErrorMessage = "Informe o nome do produto.")]
    public string Name { get; set; } = string.Empty;

    [BindProperty]
    [Range(typeof(decimal), "0.01", "999999999",
        ErrorMessage = "Informe um preço maior que zero.")]
    public decimal Price { get; set; }

    public bool Submitted { get; private set; }

    public void OnPost()
    {
        if (ModelState.IsValid)
        {
            Submitted = true;
        }
    }
}

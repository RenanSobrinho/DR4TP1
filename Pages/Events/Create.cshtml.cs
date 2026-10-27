using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProductCatalog.Pages.Events;

public class CreateModel : PageModel
{
    private readonly Action<ProductCatalog.Models.Event> _eventCreated;

    public CreateModel()
    {
        _eventCreated = createdEvent =>
        {
            Console.WriteLine(
                $"Evento criado: {createdEvent.Title} | " +
                $"{createdEvent.Date:g} | {createdEvent.Location}");
        };
    }

    [BindProperty]
    [Required(ErrorMessage = "Informe o título.")]
    public string Title { get; set; } = string.Empty;

    [BindProperty]
    [Required(ErrorMessage = "Informe a data.")]
    public DateTime Date { get; set; }

    [BindProperty]
    [Required(ErrorMessage = "Informe o local.")]
    public string Location { get; set; } = string.Empty;

    public bool Submitted { get; private set; }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
            return Page();

        var newEvent = new ProductCatalog.Models.Event
        {
            Title = Title,
            Date = Date,
            Location = Location
        };

        _eventCreated(newEvent);
        Submitted = true;

        return Page();
    }
}

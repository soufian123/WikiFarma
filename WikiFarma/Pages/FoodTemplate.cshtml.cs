using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WikiFarma.Pages;

public class FoodTemplate : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public FoodTemplate(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        
    }

    public IActionResult OnGetSearch(string query)
    {
        return Page();
    }

}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WikiFarma.Pages;

public class SearchTemplate : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public SearchTemplate(ILogger<IndexModel> logger)
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

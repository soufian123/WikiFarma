using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WikiFarma.Pages;

public class SOSTemplate : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public SOSTemplate(ILogger<IndexModel> logger)
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

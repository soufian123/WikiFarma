using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WikiFarma.Pages;

public class Test : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public Test(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}


using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using WikiFarma.Data;
using WikiFarma.Models;

namespace WikiFarma.Pages
{
    public class SearchTemplate : PageModel
    {
        private readonly WikiFarmaContext _context;
        private readonly ILogger<SearchTemplate> _logger;

        public SearchTemplate(WikiFarmaContext context, ILogger<SearchTemplate> logger)
        {
            _context = context;
            _logger = logger;
            Medicines = new List<Farmaco>();
        }

        public IList<Farmaco> Medicines { get; set; }

        public async Task<IActionResult> OnGetSearchAsync(string query)
        {
            _logger.LogInformation($"Received search query: {query}");

            if (string.IsNullOrEmpty(query))
            {
                _logger.LogInformation("Empty search query");
                Medicines.Clear();
            }
            else
            {
                _logger.LogInformation($"Performing search for: {query}");

                Medicines = await _context.Farmacos
                    .Where(m => m.Nombre.Contains(query) || m.Marca.Contains(query))
                    .ToListAsync();

                _logger.LogInformation($"Found {Medicines.Count} medicines");
            }

            return Page();
        }
    }
}

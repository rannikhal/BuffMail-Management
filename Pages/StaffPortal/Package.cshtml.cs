using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BuffMail.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;

namespace BuffMail_Management.Pages.StaffPortal;

public class PackageModel : PageModel
{
    private readonly BuffMailDbContext _context;
    private readonly ILogger<PackageModel> _logger;

    [BindProperty]
    public Package SelectedPackage {get;set;} = default!;

    public PackageModel(BuffMailDbContext context, ILogger<PackageModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        SelectedPackage = await _context.Package.Include(p => p.Resident).FirstOrDefaultAsync(p => p.PackageID == id);

        if (SelectedPackage == null)
        {
            return NotFound();
        }
        return Page();
    }

    public void OnPost()
    {
        
    }
}

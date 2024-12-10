using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BuffMail.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BuffMail_Management.Pages.StaffPortal;

public class PackageModel : PageModel
{
    private readonly BuffMailDbContext _context;
    private readonly ILogger<PackageModel> _logger;

    [BindProperty]
    public Package SelectedPackage {get;set;} = default!;
    public Resident Resident {get;set;} = default!;
    public SelectList ResidentDropDown {get;set;} = default!;

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

        ResidentDropDown = new SelectList(_context.Resident, "ResidentID", "Name");


        SelectedPackage = await _context.Package.Include(p => p.Resident).FirstOrDefaultAsync(p => p.PackageID == id);

        if (SelectedPackage == null)
        {
            return NotFound();
        }
        return Page();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Package.Update(SelectedPackage);
        _context.SaveChanges();

        return RedirectToPage("/StaffPortal/Index");
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BuffMail.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;

namespace BuffMail_Management.Pages.StaffPortal;

public class IndexModel : PageModel
{
    private readonly BuffMailDbContext _context;
    private readonly ILogger<IndexModel> _logger;

    public List<Package> PackageList {get;set;} = default!;
    public List<Package> PackagesAwaitingPickup {get;set;} = default!;
    public List<Package> UnkownPackages {get;set;} = default!;

    public IndexModel(BuffMailDbContext context, ILogger<IndexModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {
        PackageList = _context.Package.Include(p => p.Resident).ToList();
        // grabs only the packages that are awaiting pickup 
        PackagesAwaitingPickup = PackageList.Where(p => p.PackageStatus == "Awaiting Pick-up").ToList();
        // grabs only the packages that are unknown and need to be returned to sender
        UnkownPackages = PackageList.Where(p => p.PackageStatus == "Unknown/Return to Sender").ToList();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page(); // if input is invalid, it returns the page
        }

        // error message if login inputs are invalid
        ModelState.AddModelError(string.Empty, "Invalid username or password.");
        return Page();
    }
}

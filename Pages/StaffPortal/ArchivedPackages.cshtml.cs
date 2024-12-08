using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BuffMail.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BuffMail_Management.Pages.StaffPortal;

public class ArchivedPackagesModel : PageModel
{
    private readonly BuffMailDbContext _context;
    private readonly ILogger<ArchivedPackagesModel> _logger;

    public List<Package> PackageList {get;set;} = default!;
    public List<Package> ReturnedToSender {get;set;} = default!;
    public List<Package> FulfilledPackages {get;set;} = default!;

    public ArchivedPackagesModel(BuffMailDbContext context, ILogger<ArchivedPackagesModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {
        PackageList = _context.Package.ToList();
        // grabs only the packages that have been returned to the sender
        ReturnedToSender = PackageList.Where(p => p.PackageStatus == "Returned to Sender").ToList();
        // grabs only the packages that have already been fulfilled and picked-up
        FulfilledPackages = PackageList.Where(p => p.PackageStatus == "Fulfilled").ToList();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            // error message if login inputs are invalid
            ModelState.AddModelError(string.Empty, "Invalid username or password.");
            // if input is invalid, it returns the page
            return Page(); 
        }





        // shows error if there are no records on staff table
        ModelState.AddModelError(string.Empty, "No staff memebers found.");

        return Page();
    }
}

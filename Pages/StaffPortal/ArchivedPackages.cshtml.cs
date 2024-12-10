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

    public ArchivedPackagesModel(BuffMailDbContext context, ILogger<ArchivedPackagesModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {
        PackageList = _context.Package.ToList();
    }

    public void OnPost()
    {

    }
}

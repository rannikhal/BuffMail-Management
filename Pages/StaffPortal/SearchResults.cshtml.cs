using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BuffMail.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BuffMail_Management.Pages.StaffPortal;

public class SearchResultsModel : PageModel
{
    private readonly BuffMailDbContext _context;
    private readonly ILogger<SearchResultsModel> _logger;

    public string SearchTerm {get;set;}
    public List<Resident> SearchResults {get;set;}

    public SearchResultsModel(BuffMailDbContext context, ILogger<SearchResultsModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet(string searchTerm)
    {
        SearchTerm = searchTerm.ToLower();

        if (!string.IsNullOrEmpty(SearchTerm))
        {
            SearchResults = _context.Resident.Include(r => r.Packages).Where(r => (r.Name.ToLower().Contains(SearchTerm) || r.UnitNumber.ToString().Contains(searchTerm)) && r.Name.ToLower() != "unknown" && r.UnitNumber != 0).ToList();
        }
        else
        {
            SearchResults = new List<Resident>();
        }
    }

    public void OnPost()
    {
        
    }
}
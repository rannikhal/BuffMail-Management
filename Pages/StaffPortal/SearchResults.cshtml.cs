// using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Mvc.RazorPages;
// using BuffMail.Models;
// using System.ComponentModel.DataAnnotations;
// using Microsoft.EntityFrameworkCore.Metadata.Internal;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.AspNetCore.Mvc.Rendering;

// namespace BuffMail_Management.Pages.StaffPortal;

// public class SearchResultsModel : PageModel
// {
//     private readonly BuffMailDbContext _context;
//     private readonly ILogger<SearchResultsModel> _logger;

//     public string SearchTerm {get;set;}

//     public SearchResultsModel(BuffMailDbContext context, ILogger<SearchResultsModel> logger)
//     {
//         _context = context;
//         _logger = logger;
//     }

//     public void OnGet()
//     {
//         SearchTerm = Request.Query["searchTerm"];

//         List<Resident> SearchResults = _context.Resident.Where(r => r.Name.Contains(SearchTerm));
//     }

//     public IActionResult OnPost()
//     {
//         if (!ModelState.IsValid)
//         {
//             return Page();
//         }

//         _context.Package.Update(SelectedPackage);
//         _context.SaveChanges();

//         return RedirectToPage("/StaffPortal/Index");
//     }
// }
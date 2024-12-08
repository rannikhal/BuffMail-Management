using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BuffMail.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BuffMail_Management.Pages;

public class IndexModel : PageModel
{
    private readonly BuffMailDbContext _context;
    private readonly ILogger<IndexModel> _logger;

    [Display(Name = "")]
    [Required]
    public string InputUsername {get;set;} = default!;

    [Display(Name = "")]
    [Required]
    public string InputPassword {get;set;} = default!;
    public List<Staff> StaffList {get;set;} = default!;

    public IndexModel(BuffMailDbContext context, ILogger<IndexModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {

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

        try
        {
            StaffList = _context.Staff.ToList();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to retrieve staff list from the database.");
            ModelState.AddModelError(string.Empty, "Unable to process your request at this time.");
            return Page();
        }

        if (StaffList == null || !StaffList.Any())
        {
            ModelState.AddModelError(string.Empty, "No staff members found."); 
            return Page();
        }

        Staff staff = StaffList.FirstOrDefault(s => s.Username.Equals(InputUsername, StringComparison.OrdinalIgnoreCase) && s.Password == InputPassword);
        
        // validates username and password 
        if (staff == null)
        {
            // shows error if there are no records on staff table
            ModelState.AddModelError(string.Empty, "Invalid username or password.");
            return Page();
        }

        return RedirectToPage("/StaffPortal/Index");
    }
}

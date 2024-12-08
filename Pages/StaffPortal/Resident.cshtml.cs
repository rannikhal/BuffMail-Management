using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BuffMail.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;

namespace BuffMail_Management.Pages.StaffPortal;

public class ResidentModel : PageModel
{
    private readonly BuffMailDbContext _context;
    private readonly ILogger<ResidentModel> _logger;

    [BindProperty]
    public Resident SelectedResident {get;set;} = default!;

    public ResidentModel(BuffMailDbContext context, ILogger<ResidentModel> logger)
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

        SelectedResident = await _context.Resident.FirstOrDefaultAsync(p => p.ResidentID == id);

        if (SelectedResident == null)
        {
            return NotFound();
        }
        return Page();
    }

    public void OnPost()
    {
        
    }
}

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;

namespace BuffMail.Models
{
    public class Resident
    {
        public int ResidentID {get;set;} // PK

        [BindProperty]
        [Display(Name = "Name")]
        [StringLength(40)]
        [Required]
        public string? Name {get;set;}

        [BindProperty]
        [Display(Name = "E-mail")]
        [StringLength(40)]
        [EmailAddress]
        [Required]
        public string? Email {get;set;}

        [BindProperty]
        [Display(Name = "Dorm Number")]
        [Required]
        public int UnitNumber {get;set;}

        public List<Package> Packages {get;set;} = new List<Package>(); // navigation property that connects to Package
    }
}
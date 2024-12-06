using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;

namespace BuffMail.Models
{
    public class Package
    {
        public int PackageID {get;set;} // PK

        [BindProperty]
        [Display(Name = "Postal Service Agency")]
        [StringLength(20)]
        [Required]
        public string? PostalServiceAgency {get;set;}

        [BindProperty]
        [Display(Name = "Delivery Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DeliveryDate {get;set;}

        [BindProperty]
        [Display(Name = "Package Status")]
        [StringLength(20)]
        [Required]
        public string? PackageStatus {get;set;}

        public Resident Resident {get;set;} = null!; // navigation property that connects to Resident
        public int ResidentID {get;set;} // FK
    } 
}
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;

namespace BuffMail.Models
{
    public class Staff
    {
        public int StaffID {get;set;} //PK

        [BindProperty]
        [Display(Name = "Username")]
        [StringLength(30)]
        [Required]
        public string? Username {get;set;}

        [BindProperty]
        [Display(Name = "Password")]
        [PasswordPropertyText]
        [StringLength(30)]
        [Required]
        public string? Password{get;set;}
    }
}
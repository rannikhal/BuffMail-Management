using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;

namespace BuffMail.Models
{
    public class Staff
    {
        public int StaffID {get;set;} //PK
        public string? Username {get;set;}
        public string? Password{get;set;}
    }
}
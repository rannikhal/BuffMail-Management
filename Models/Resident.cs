using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;

namespace BuffMail.Models
{
    public class Resident
    {
        public int ResidentID {get;set;} // PK
        public string? Name {get;set;}
        public string? Email {get;set;}
        public int UnitNumber {get;set;}

        public List<Package> Packages {get;set;} = new List<Package>(); // navigation property that connects to Package

        public Unit Unit {get;set;} = null!; // navigation property that connects to Unit
        public int UnitID {get;set;} // FK
    }
}
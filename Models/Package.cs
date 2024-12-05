using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;

namespace BuffMail.Models
{
    public class Package
    {
        public int PackageID {get;set;} // PK
        public string? PostalServiceAgency {get;set;}
        public DateTime DeliveryDate {get;set;}
        public string? PackageStatus {get;set;}
        public string? PackageNotes {get;set;}

        public Resident Resident {get;set;} = null!; // navigation property that connects to Resident
        public int ResidentID {get;set;} // FK
    } 
}
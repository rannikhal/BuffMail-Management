using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;

namespace BuffMail.Models
{
    public class Unit
    {
        public int UnitID {get;set;} // PK
        public int UnitNumber {get;set;}

        public List<Resident> Residents = new List<Resident>(); // navigation property that connects to Resident
    }
}
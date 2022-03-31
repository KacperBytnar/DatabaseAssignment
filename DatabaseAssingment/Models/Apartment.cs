using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseAssingment.Models
{
    public partial class Apartment
    {
        public Apartment()
        {   
        }
        [Key]
        public int Apartment_No { get; set; }
        [Required]
        public string Address { get; set; }
        public string Types;

    }
}

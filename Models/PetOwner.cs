using System.Collections.Generic;
using System;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace pet_hotel.Models
{
    public class PetOwner
    {
        // unique id
        public int id { get; set; }
        // emailAddress
        [Required]
        public string emailAddress { get; set; }

        // name
        [Required]
        public string name { get; set; }
        // petCount
        // public int petCount { get; set; }
    }
}

﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using Garage_2._0.Auxilary;
using System.ComponentModel.DataAnnotations;
using Garage_2._0.Validations;

namespace Garage_2._0.Models
{
    public class Member
    {
        public int Id { get; set; }

        [DisplayName("Förnamn")]
        public string FirstName { get; set; }

        [DisplayName("Efternamn")]
        [FullName(ErrorMessage = "Förnamn och Efternamn kan inte vara samma!")]
        public string LastName { get; set; }

        [DisplayName("Personnummer")]
        public string PersNr { get; set; }

        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
    }
}

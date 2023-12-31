﻿using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Models.Country
{
    public class UpdateCountryDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}

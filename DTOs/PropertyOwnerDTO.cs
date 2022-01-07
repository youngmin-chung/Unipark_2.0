﻿using System.Collections;
using System.Collections.Generic;

namespace serverapp.DTOs
{
    public class PropertyOwnerDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public double Ranking { get; set; }
        public string Email { get; set; }
        public string EmergencyContact { get; set; }
        public int CurrentUserMode { get; set; }
        public ICollection<DocumentDTO> Documents { get; set; }
    }
}

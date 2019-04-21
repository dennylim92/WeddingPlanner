using System;
using System.Collections.Generic;

namespace WeddingPlanner.Models
{
    public class User : DateModel
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }



        // NAVIGATION
        public List<Wedding> Weddings{ get; set; }
        public List<RSVP> RSVPs { get; set; }
    }
}
using System;
using System.Collections.Generic;

namespace WeddingPlanner.Models
{
    public class WeddingAndGuest
    {
        public List<RSVP> AllGuests{ get; set; }
        public Wedding Wedding{ get; set; }

    }
}
using System;
using System.Collections.Generic;

namespace WeddingPlanner.Models
{
    public class Wedding : DateModel
    {
        public int WeddingId { get; set; }
        public string WedderOne { get; set; }
        public string WedderTwo { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public int UserId { get; set; }




        // NAVIGATION
        public User Person { get; set; }
        public List<RSVP> Guests { get; set; }
    }
}
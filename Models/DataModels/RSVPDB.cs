using System;
namespace WeddingPlanner.Models
{
    public class RSVP : DateModel
    {
        public int RSVPId { get; set; }
        public int UserId { get; set; }
        public int WeddingId { get; set; }



        // NAVIGATION
        public User Person { get; set; }
        public Wedding Wedding { get; set; }

    }
}
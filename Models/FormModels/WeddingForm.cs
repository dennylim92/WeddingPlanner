using System;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class WeddingForm
    {
        [Required]
        public string WedderOne { get; set; }

        [Required]
        public string WedderTwo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        public string Address { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models
{
    public class UserForm
    {
        public int UserId {get;set;}

        [Required(ErrorMessage = "First name needs to be at least 2 characters.")]
        [MinLength(2)]
        public string FirstName {get;set;}

        [Required(ErrorMessage = "Last name needs to be at least 2 characters.")]
        [MinLength(2)]
        public string LastName {get;set;}
        
        [Required(ErrorMessage = "Please enter a valid Email.")]
        [EmailAddress]
        public string Email {get;set;}

        [Required(ErrorMessage = "Password needs to be at least 8 characters.")]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password {get;set;}

        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword {get;set;}

    }
}
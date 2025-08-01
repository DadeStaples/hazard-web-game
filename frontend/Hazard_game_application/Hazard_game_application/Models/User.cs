using System;
using System.ComponentModel.DataAnnotations;

namespace Hazard_game_application.Models
{
    public class User
    {

        [Required, MinLength(3)]
        [RegularExpression(@"^\S+$", ErrorMessage = "Username cannot contain spaces.")]
        public string Username { get; set; } = "";

        [Required, MinLength(6)]
        [RegularExpression(@"^\S+$", ErrorMessage = "Password cannot contain spaces.")]
        public string Password { get; set; } = "";

        public string Role { get; set; } = "user";
    }
}
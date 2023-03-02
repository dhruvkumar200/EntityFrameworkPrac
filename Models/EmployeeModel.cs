using System;
using System.ComponentModel.DataAnnotations;
public class EmployeeModel

 {
    //   [Required]
//     [StringLength(8, ErrorMessage = "Name length can't be more than 8.")]
//         public string? FirstName { get; set; }
//     [Required]

    // public string? LastName { get; set; }
     [EmailAddress (ErrorMessage="please enter valid email")]
    public string? Email { get; set; }
[Required(ErrorMessage = "Password is required.")]
[RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$", ErrorMessage = "Passwords must be at least 8 characters and contain at 3 of 4 of the following: upper case (A-Z), lower case (a-z), number (0-9) and special character (e.g. !@#$%^&*)")]

    public string? Password { get; set; }
//  [Compare(nameof(Password), ErrorMessage = "confirm password and password not match")]
//     public string? ConfirmPassword { get; set; }

    // public string? Contact { get; set; }
}
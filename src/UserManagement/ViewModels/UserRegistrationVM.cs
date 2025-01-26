using System.ComponentModel.DataAnnotations;

namespace UserManagement.ViewModels;
public class UserRegistrationVM
{
    private const string PASSWORD_MISMATCH_ERROR_MESSAGE = "Password are different";

    public int Id { get; set; }

    [Required]
    [EmailAddress]
    public required string Email { get; set; }

    [Required]
    [MinLength(8), MaxLength(30)]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,30}$")]
    public string Password { get; set; }

    [Compare(nameof(Password), ErrorMessage = PASSWORD_MISMATCH_ERROR_MESSAGE)]
    public string SecondPassword { get; set; }
}

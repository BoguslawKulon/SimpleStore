using UserManagemet.Entities;

namespace UserManagement.Models;

internal class UserRegistration
{
    public UserId Id { get; set; }
    public Email Email { get; set; }
    public PasswordHash PasswordHash { get; set; }
}

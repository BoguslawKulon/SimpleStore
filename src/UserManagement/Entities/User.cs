namespace UserManagemet.Entities;

internal class User
{
    public UserId Id { get; set; }
    public Email Email { get; set; }
    public PasswordHash PasswordHash { get; set; }
    public EmailType EmailType { get; set; }
}

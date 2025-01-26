using UserManagemet.Entities;

namespace UserManagement.Dtos;
internal class UserDataDto
{
    public UserId Id { get; set; }
    public PersonName Name { get; set; }
    public Email Email { get; set; }
}

using UserManagement.Dtos;
using UserManagement.Models;
using UserManagemet.Entities;

namespace UserManagement.Repositories;
internal class UserRepositoryStub : IUserReadRepository, IUserSaveRepository
{
    private readonly List<UserRegistration> _users = new();

    public bool DoesEmailExists(Email email)
    {
        return _users.Any(u => email.Equals(u.Email));
    }

    public void RegistrationSave(UserRegistration user)
    {
        _users.Add(user);
    }

    public UserDataDto GetByEmail(Email email)
    {
        var dbUser = _users.First(u => email.Equals(u.Email));

        return new UserDataDto(
            string.Empty,
            string.Empty,
            dbUser.Email.Value,
            string.Empty);
    }
}

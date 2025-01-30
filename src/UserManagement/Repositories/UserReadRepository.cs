using UserManagement.Dtos;
using UserManagemet.Entities;

namespace UserManagement.Repositories;
internal class UserReadRepository : IUserReadRepository
{
    public bool DoesEmailExists(Email email)
    {
        throw new NotImplementedException();
    }

    public UserDataDto GetByEmail(Email email)
    {
        throw new NotImplementedException();
    }
}

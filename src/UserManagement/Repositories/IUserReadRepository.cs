using UserManagement.Dtos;
using UserManagemet.Entities;

namespace UserManagement.Repositories;

internal interface IUserReadRepository
{
    bool DoesEmailExists(Email email);
    UserDataDto GetByEmail(Email email);
}
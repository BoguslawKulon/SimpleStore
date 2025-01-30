using UserManagement.Dtos;
using UserManagement.Repositories;
using UserManagemet.Entities;

namespace UserManagement.Services;

internal class UserService
{
    private readonly IUserReadRepository _userReadRepository;

    public UserService(IUserReadRepository userReadRepository)
    {
        _userReadRepository = userReadRepository;
    }

    public UserDataDto GetByEmail(Email email)
    {
        return _userReadRepository.GetByEmail(email);
    }
}

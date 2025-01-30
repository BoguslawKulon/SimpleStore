using UserManagement.Dtos;
using UserManagement.Exceptions;
using UserManagement.Models;
using UserManagement.Repositories;
using UserManagement.ViewModels;
using UserManagemet.Entities;

namespace UserManagement.Services;

internal class UserRegistrationService : IUserRegistrationService
{
    private readonly IUserReadRepository _userReadRepository;
    private readonly IUserSaveRepository _userSaveRepository;

    public UserRegistrationService(IUserReadRepository userReadRepository, IUserSaveRepository userSaveRepository)
    {
        _userReadRepository = userReadRepository;
        _userSaveRepository = userSaveRepository;
    }

    public UserDataDto GetUserData()
    {
        throw new NotImplementedException();
    }

    public void RegisterUser(UserRegistration user)
    {
        if (_userReadRepository.DoesEmailExists(user.Email))
        {
            throw new EmailAlreadyExistsException();
        }

        _userSaveRepository.RegistrationSave(user);
    }
}

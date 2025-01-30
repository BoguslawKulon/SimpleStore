using UserManagement.Models;

namespace UserManagement.Repositories;

internal interface IUserSaveRepository
{
    void RegistrationSave(UserRegistration user);
}
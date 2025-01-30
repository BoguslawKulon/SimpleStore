using UserManagement.Dtos;
using UserManagement.Exceptions;
using UserManagement.Models;
using UserManagement.Repositories;
using UserManagement.Services;
using UserManagement.ViewModels;
using UserManagemet.Entities;

namespace UserManagement.Tests;

public class UserRegistrationTests
{
    [Fact]
    public void SaveTest()
    {
        // Arrange
        var user = new UserRegistration { 
            Email = new Email("example@domain.com"),
        };

        var userRepository = new UserRepositoryStub();
        var registrationService = new UserRegistrationService(userRepository, userRepository);
        var userService = new UserService(userRepository);

        // Act
        registrationService.RegisterUser(user);

        var savedUser = userService.GetByEmail(user.Email);

        // Assert
        Assert.Equal(user.Email.Value, savedUser.Email);
    }

    [Fact]
    public void SameEmail_ThrowException()
    {
        // Arrange
        var user = new UserRegistration { 
            Email = new Email("example@domain.com"),
        };
        var userRepository = new UserRepositoryStub();

        // Act
        var registrationService = new UserRegistrationService(userRepository, userRepository);

        registrationService.RegisterUser(user);

        // Assert
        Assert.Throws<EmailAlreadyExistsException>(() => registrationService.RegisterUser(user));
        
    }
}
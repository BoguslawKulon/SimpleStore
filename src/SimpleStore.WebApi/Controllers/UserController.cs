using Microsoft.AspNetCore.Mvc;
using UserManagement.Dtos;
using UserManagement.Services;
using UserManagement.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleStore.WebApi.Controllers;
[Route("api/users")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserRegistrationService _userRegistrationService;

    public UserController(IUserRegistrationService userService)
    {
        _userRegistrationService = userService;
    }

    // GET api/<UserController>/account
    [HttpGet("/account")]
    public ActionResult<UserDataDto> Get()
    {
        var user = _userRegistrationService.GetUserData();
        return user;
    }

    // POST api/<UserController>
    [HttpPost]
    public ActionResult Save([FromBody] UserRegistrationVM user)
    {
        if (!ModelState.IsValid)
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
            return BadRequest(ModelState);
        }
    }

    // PUT api/<UserController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<UserController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}

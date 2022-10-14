using FireBaseAuthApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Firebase.Auth;

namespace FireBaseAuthApi.Controllers;

[ApiController]
public class FirebaseController : ControllerBase
{
    const string API_KEY = "AIzaSyC__fXAe7B65SJcWERUtKXBISZ8xF4jgq0";
    
    [Authorize]
    [HttpGet("/")]
    public IActionResult GetRequest()
    {
        return Ok();
    }
    
    [HttpPost("create-user")]
    public async Task<ActionResult<bool>> CreateUser(Register registerModel)
    {
        FirebaseAuthProvider firebaseAuthProvider = new FirebaseAuthProvider(new FirebaseConfig(API_KEY));  
        FirebaseAuthLink firebaseAuthLink = await firebaseAuthProvider.CreateUserWithEmailAndPasswordAsync(registerModel.Email,registerModel.Password,registerModel.DisplayName);

        return Ok(true);
    }
    
    [HttpPost("sign-in")]
    public async Task<ActionResult<bool>> SignIn(Register registerModel)
    {
        FirebaseAuthProvider firebaseAuthProvider = new FirebaseAuthProvider(new FirebaseConfig(API_KEY));  
        FirebaseAuthLink firebaseAuthLink = await firebaseAuthProvider.SignInWithEmailAndPasswordAsync(registerModel.Email,registerModel.Password);

        return Ok(true);
    }
}
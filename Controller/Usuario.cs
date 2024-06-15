using Microsoft.AspNetCore.Mvc;
using Models.DTO.Usuario;
using repositories;
using technical_challenge_of_picpay.Services.interfaces;

namespace technical_challenge_of_picpay.Controller;

[ApiController]
public class Usuario : ControllerBase
{
  private readonly IUsuarioServices _services;

  public Usuario( IUsuarioServices services)
  {
    _services = services;
  }

  [HttpGet]
  [Route("/Usuario")]
  public IActionResult GetUserInfo()
  {
    return Ok(_services.GetInfoUser());
  }


  [HttpGet]
  [Route("/Usuario/{email}")]
  public IActionResult GetAdmInfoUser(string email)
  {
    return Ok(_services.GetAdmInfoUser(email));
  }

  [HttpPost]
  [Route("/Usuario")]
  public IActionResult AddNewUser(UsuarioRequest request)
  {
    if (!ModelState.IsValid)
    {
      return BadRequest(request);
    }

    var new_student = _services.AddNewUser(request);

    return Ok(new_student);
  }
  
  
}

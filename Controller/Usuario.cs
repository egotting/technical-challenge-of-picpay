using Microsoft.AspNetCore.Mvc;
using repositories;
using technical_challenge_of_picpay.Services.interfaces;

namespace technical_challenge_of_picpay.Controller;

[ApiController]
[Route("v1")]
public class Usuario : ControllerBase
{
    protected readonly IUsuarioRepository _repo;
    protected readonly IUsuarioServices _services;

    public Usuario(IUsuarioRepository repo, IUsuarioServices services)
    {
        _repo = repo;
        _services = services;
    }
    
    [HttpGet]
    [Route("/Usuario/{p_id}")]
    public IActionResult GetSaldo(Guid p_id)
    {
        return Ok(_repo.GetAdmInfoUser(p_id));
    }
    
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Models.DTO.Logista;
using technical_challenge_of_picpay.Services.interfaces;

namespace technical_challenge_of_picpay.Controller;

[ApiController]
[Route("v1")]
public class Logista : ControllerBase
{
    private readonly ILogistaServices _services;

    public Logista(ILogistaServices services)
    {
        _services = services;
    }

    [HttpGet]
    [Route("/Logista")]
    public IActionResult GetLogistaInfo()
    {
        return Ok(_services.GetInfoLogista());
    }


    [HttpGet]
    [Route("/Logista/{cnpj}")]
    public IActionResult GetAdmLogistaInfo(string cnpj)
    {
        return Ok(_services.GetInfoAdmLogista(cnpj));
    }
    
    [HttpPost]
    [Route("/Logista")]
    public IActionResult AddNewLogista([FromBody] LogistaRequest newLogi)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(newLogi);
        }

        var new_logi = _services.AddNewLogista(newLogi);
        return Ok(new_logi);
    }
}
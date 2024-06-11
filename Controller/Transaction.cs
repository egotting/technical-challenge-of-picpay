using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using Models.DTO;
using technical_challenge_of_picpay.Services.interfaces;

namespace technical_challenge_of_picpay.Controller;

[ApiController]
public class Transaction : ControllerBase
{
    private readonly ITransacaoService _service;

    public Transaction(ITransacaoService service)
    {
        _service = service;
    }

    [HttpPatch]
    [Route("/Transaction")]
    public IActionResult TransactionUser(TransactionRequestUser user)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _service.TransactionUser(user); 
        return Created();
    }

    [HttpPatch]
    [Route("/TransactionLogist")]
    public IActionResult TransactionLogist(TransactionRequestLogista logist)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        
        _service.TransactionUserToLogist(logist);
        return Created();
    }
}
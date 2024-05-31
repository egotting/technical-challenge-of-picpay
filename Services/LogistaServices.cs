using Models;
using Models.DTO.Logista;
using repositories;
using technical_challenge_of_picpay.Services.interfaces;

namespace technical_challenge_of_picpay.Services;

public class LogistaServices : ILogistaServices
{
    private readonly ILogistaRepository _repo;


    public LogistaServices(ILogistaRepository repo)
    {
        _repo = repo;
    }
    
    public IEnumerable<LogistaResponse> GetInfoLogista()
    {
        return _repo.GetInfoLogista().Select(logista => 
            new LogistaResponse(logista.FullName,logista.Cnpj,
                logista.Email,logista.Saldo)).ToList();
    }

    public Logista GetInfoAdmLogista(string cnpj)
    {
        var logista = _repo.GetAdmInfoLogista(cnpj);
        return logista;
    }

    public AddNewLogistaResponse AddNewLogista(LogistaRequest request)
    {
        var newLogi = new Logista(request.FullName, request.Email, request.Cnpj, request.Senha, request.Saldo);

        newLogi = _repo.AddNewLogista(newLogi);

        return new AddNewLogistaResponse(newLogi.FullName, newLogi.Email, newLogi.Cnpj, newLogi.Senha);
    }
}
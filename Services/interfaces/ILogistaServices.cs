using Models;
using Models.DTO.Logista;

namespace technical_challenge_of_picpay.Services.interfaces;

public interface ILogistaServices
{
    public IEnumerable<LogistaResponse> GetInfoLogista();

    public Logista GetInfoAdmLogista(string cnpj);

    public AddNewLogistaResponse AddNewLogista(LogistaRequest request);
}
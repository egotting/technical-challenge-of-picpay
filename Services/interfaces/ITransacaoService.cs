using Models;
using Models.DTO;

namespace technical_challenge_of_picpay.Services.interfaces;

public interface ITransacaoService
{
    public void TransactionUser(TransactionRequestUser transaction);
    public void TransactionUserToLogist(TransactionRequestLogista transaction);
}
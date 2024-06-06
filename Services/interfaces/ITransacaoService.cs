using Models;
using Models.DTO;

namespace technical_challenge_of_picpay.Services.interfaces;

public interface ITransacaoService
{ 

    public void TransactionUser(TransactionRequestUser user);
}
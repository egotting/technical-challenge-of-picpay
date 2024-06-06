using Models;
using Models.DTO;
using repositories;
using technical_challenge_of_picpay.Exceptions;
using technical_challenge_of_picpay.Services.interfaces;

namespace technical_challenge_of_picpay.Services;

public class TransacaoService : ITransacaoService
{
    private readonly IUsuarioRepository _repo;


    public TransacaoService(IUsuarioRepository repo)
    {
        _repo = repo;
    }

    public void TransactionUser(TransactionRequestUser transaction)
    {
        
        
        var search_remetente = _repo.GetAdmInfoUser(transaction.EmailRemetente)
                               ?? throw new NotFoundUsuario("Not found user");
        var search_recebedor = _repo.GetAdmInfoUser(transaction.EmailRecebedor)
                              ?? throw new NotFoundUsuario("Not found user");

        if (search_remetente.Saldo >= transaction.Valor)
        {
            search_recebedor.Saldo += transaction.Valor;
            search_remetente.Saldo -= transaction.Valor;
            _repo.UpdateUser(search_remetente, search_recebedor);
        }
        else
        {
            throw new DontHaveBalance("Não tem saldo suficente");
        }
    }
}
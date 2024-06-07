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
        var search_remetente =
            _repo.GetAdmInfoUser(transaction.EmailRemetente) // Pegando O email do quem vai enviar o dinheiro
            ?? throw new NotFoundUsuario("Not found user");
        var search_recebedor =
            _repo.GetAdmInfoUser(transaction.EmailRecebedor) // Pegando o email de quem vai receber o dinheiro
            ?? throw new NotFoundUsuario("Not found user");

        if (search_remetente.Saldo >= transaction.Valor) // Verificando se o saldo de quem vai enviar
        {
            search_recebedor.Saldo +=
                transaction.Valor; // Adicionando e somando o valor existente ao recebedor no caso se o recebedor tivesse 10 e o remetente enviou 10 vai soma com o 10 do recebedor e se tornar 20
            search_remetente.Saldo -=
                transaction.Valor; // Fazendo o completo oposto ele esta diminuindo no caso tirando o valor do saldo do remetente no caso 10 - 10 e se o remetente so tiver 10 vai ir pra 0 
            _repo.UpdateUser(search_remetente, search_recebedor); // Atualizando o usuario com update no repo
        }
        else
        {
            throw new DontHaveBalance("Não tem saldo suficente");
        }
    }
}
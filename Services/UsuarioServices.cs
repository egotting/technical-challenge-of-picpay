using Models;
using Models.DTO.Usuario;
using repositories;
using technical_challenge_of_picpay.Services.interfaces;

namespace technical_challenge_of_picpay.Services;

public class UsuarioServices : IUsuarioServices
{
    private readonly IUsuarioRepository _repo;

    public UsuarioServices(IUsuarioRepository repo)
    {
        _repo = repo;
    }


    public IEnumerable<UsuarioResponse> GetInfoUser()
    {
        return _repo.GetInfoUser().Select(user =>
            new UsuarioResponse(user.FullName, user.Cpf_Cnpj, user.Email,
                user.Saldo, user.Chave)).ToList();
    }

    public Usuario GetAdmInfoUser(string email)
    {
        var user = _repo.GetAdmInfoUser(email);
        return user;
    }

}
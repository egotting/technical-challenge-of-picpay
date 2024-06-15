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
            new UsuarioResponse(user.FullName, user.Cpf, user.Email,
                user.Saldo)).ToList();
    }

    public Usuario GetAdmInfoUser(string email)
    {
        var user = _repo.GetAdmInfoUser(email);
        return user;
    }

    public UsuarioResponse AddNewUser(UsuarioRequest request)
    {
        var new_user =
            new Usuario(request.FullName, request.Cpf, request.Email, request.Senha, request.ConfirmSenha,
                request.Saldo); // tudo que o cliente digitar no request vai ser add no banco

        new_user = _repo.AddNewUser(new_user); // add novo usuario
        return new UsuarioResponse(new_user.FullName, new_user.Cpf, new_user.Email,
            new_user.Saldo); // retornando os foi adicionado no banco
    }
}
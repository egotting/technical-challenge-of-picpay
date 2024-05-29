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
    public UsuarioResponse GetInfoUser(Guid p_id)
    {
        return null;
    }
}
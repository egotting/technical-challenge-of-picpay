using Models;
using Models.DTO.Usuario;

namespace technical_challenge_of_picpay.Services.interfaces;

public interface IUsuarioServices
{
    public UsuarioResponse GetInfoUser(Guid p_id);
}
using Models;
using Models.DTO.Usuario;

namespace repositories;

public interface IUsuarioRepository
{
  public Usuario GetAdmInfoUser(Guid p_id);
}

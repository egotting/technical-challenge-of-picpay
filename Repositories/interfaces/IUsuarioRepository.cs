
using Models;

namespace repositories;

public interface IUsuarioRepository
{
  public IEnumerable<Usuario> GetInfoUser  ();

  public Usuario GetAdmInfoUser(string email);
}

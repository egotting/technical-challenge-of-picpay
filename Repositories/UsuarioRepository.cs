using Models;
using repositories;
using technical_challenge_of_picpay.Exceptions;

namespace technical_challenge_of_picpay.Repositories;

public class UsuarioRepository : IUsuarioRepository
{

  private readonly ModelContext _context;

  public UsuarioRepository(ModelContext context)
  {
    _context = context;
  }

  public IEnumerable<Usuario> GetInfoUser()
  {
    return _context.Usuarios.ToList();
  }

  public Usuario GetAdmInfoUser(string email)
  {
    return _context.Usuarios.Where(e => e.Email == email)
             .FirstOrDefault(x => x.Email == email)
           ?? throw new NotFoundUsuario("Usuario nao achado");
  }
}

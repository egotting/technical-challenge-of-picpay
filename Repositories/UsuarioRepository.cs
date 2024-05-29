using Models;
using Models.DTO.Usuario;
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

  public Usuario GetAdmInfoUser(Guid p_id)
  {
    return _context.Usuarios.Where(u => u.PId == p_id)
             .FirstOrDefault(x => x.PId == p_id) 
           ?? throw new NotFoundSaldoExceptions("Not found usuario");
  }
}
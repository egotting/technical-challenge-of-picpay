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

    public Usuario AddNewUser(Usuario newUser)
    {
        _context.Usuarios.Add(newUser);
        _context.SaveChangesAsync();
        return newUser;
    }



    public void UpdateUser(Usuario UserRemetente, Usuario UserRecebedor)
    {
        using (var transaction = _context.Database.BeginTransaction())
        {
            try
            {
                _context.Usuarios.Update(UserRemetente);
                _context.Usuarios.Update(UserRecebedor);
                _context.SaveChanges();

                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
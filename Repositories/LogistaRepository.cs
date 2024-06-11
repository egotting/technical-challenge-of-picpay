using Models;
using repositories;
using technical_challenge_of_picpay.Exceptions;

namespace technical_challenge_of_picpay.Repositories;

public class LogistaRepository : ILogistaRepository
{
    private readonly ModelContext _context;


    public LogistaRepository(ModelContext context)
    {
        _context = context;
    }


    public IEnumerable<Logista> GetInfoLogista()
    {
        return _context.Logistas.ToList();
    }

    public Logista GetAdmInfoLogista(string cnpj)
    {
        return _context.Logistas.Where(e => e.Cnpj == cnpj)
                   .FirstOrDefault(u => u.Cnpj == cnpj)
               ?? throw new NotFoundLogista("Not found logista");
    }

    public Logista AddNewLogista(Logista newLogi)
    {
        _context.Logistas.Add(newLogi);
        _context.SaveChangesAsync();
        return newLogi;
    }

    public void UpdateLogista(Usuario usuarioRemetente, Logista logistaRecebedor)
    {
        using (var transection = _context.Database.BeginTransaction())
        {
            try
            {
                _context.Usuarios.Update(usuarioRemetente);
                _context.Logistas.Update(logistaRecebedor);
                _context.SaveChanges();

                transection.Commit();
            }
            catch (Exception e)
            {
                transection.Rollback();
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
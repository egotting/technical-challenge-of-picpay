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
}
using Models;
using repositories;

namespace technical_challenge_of_picpay.Repositories;

public class TransacaoRepository : ITransacaoRepository
{
    private readonly ModelContext _context;

    public TransacaoRepository(ModelContext context)
    {
        _context = context;
    }

}
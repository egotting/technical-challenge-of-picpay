using Models;

namespace repositories;

public interface ILogistaRepository
{
    public IEnumerable<Logista> GetInfoLogista();
    public Logista GetAdmInfoLogista(string cnpj);

    public Logista AddNewLogista(Logista newLogi);
}
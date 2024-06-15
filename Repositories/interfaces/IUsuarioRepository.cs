using Models;

namespace repositories;

public interface IUsuarioRepository
{
    public IEnumerable<Usuario> GetInfoUser();

    public Usuario GetAdmInfoUser(string email);

    public Usuario AddNewUser(Usuario newUser);

    public void UpdateUser(Usuario UserRemetente, Usuario UserRecebedor);
}
namespace Models.DTO.Usuario;

// É o retorno que o usuario vai ver 
public record UsuarioResponse(string FullName,  string Cpf, string Email,  float Saldo);

namespace Models.DTO.Usuario;

public record UsuarioResponse(string FullName, string Cpf_Cnpj, string Email, float Saldo,Guid chave);

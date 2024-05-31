using System.ComponentModel.DataAnnotations;

namespace Models.DTO.Usuario;

public record UsuarioRequest(
    [Required(ErrorMessage = "Precisa colocar o seu nome completo")] 
    string FullName,
    [Required(ErrorMessage = "Precisa colocar o seu nome completo")] 
    string Email,
    [Required(ErrorMessage = "Precisa colocar o seu nome completo")] 
    string Cpf,
    [Required(ErrorMessage = "Precisa colocar o seu nome completo")] 
    string Senha,
    float Saldo
    );
using System.ComponentModel.DataAnnotations;

namespace Models.DTO.Usuario;

public record UsuarioRequest(
    [Required(ErrorMessage = "Precisa colocar o seu nome completo")] 
    string FullName,
    [Required(ErrorMessage = "Precisa colocar o seu nome completo")] 
    string Cpf_Cnpj,
    [Required(ErrorMessage = "Precisa colocar o seu nome completo")] 
    string Email
    );
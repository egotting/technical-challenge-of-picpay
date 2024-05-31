using System.ComponentModel.DataAnnotations;

namespace Models.DTO.Logista;

public record LogistaRequest(
    [Required(ErrorMessage = "Precisa colocar o seu nome  completo")] 
    string FullName,
    [Required(ErrorMessage = "Precisa colocar o seu cnpj ")] 
    string Email,
    [Required(ErrorMessage = "Precisa colocar o seu email ")] 
    string Cnpj,
    [Required(ErrorMessage = "Precisa colocar uma senha ")]
    string Senha,
    float Saldo
    );
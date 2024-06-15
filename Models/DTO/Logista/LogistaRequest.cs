using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using technical_challenge_of_picpay.Validations;

namespace Models.DTO.Logista;

// Tudo que o client for digitar vai passar pelo Request
public record LogistaRequest(
    [Required(ErrorMessage = "Precisa colocar o seu nome  completo")]
    string FullName,
    [Required(ErrorMessage = "Precisa colocar o seu cnpj "), ValidateCpf(ErrorMessage = "Não é cnpj")]
    string Cnpj,
    [Required(ErrorMessage = "Precisa colocar o seu email "), EmailAddress(ErrorMessage = "Não é um email")]
    string Email,
    [Required(ErrorMessage = "Precisa colocar uma senha ")]
    [DataType(DataType.Password)]
    string Senha,
    [Required(ErrorMessage = "Precisa colocar a senha novamente ")]
    [DataType(DataType.Password)]
    string ConfirmSenha,
    [Range(0.01, double.MaxValue, ErrorMessage = "O preço deve ser um valor positivo")]
    float Saldo
);
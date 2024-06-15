using System.Collections;
using System.ComponentModel.DataAnnotations;
using technical_challenge_of_picpay.Migrations;
using technical_challenge_of_picpay.Validations;

namespace Models.DTO.Usuario;

// As informações que vai ser levada pro banco
public record UsuarioRequest(
    [Required(ErrorMessage = "Precisa colocar o seu nome completo")]
    string FullName,
    [Required(ErrorMessage = "Precisa colocar o seu nome completo"), EmailAddress(ErrorMessage = "Isso não é um email")]
    string Email,
    [Required(ErrorMessage = "Precisa colocar o seu nome completo"), ValidateCpf(ErrorMessage = "Não é o cpf")]
    string Cpf,
    [Required(ErrorMessage = "Precisa colocar o seu nome completo")]
    [DataType(DataType.Password)]
    string Senha,
    [Required(ErrorMessage = "Precisa colocar o seu nome completo")]
    string ConfirmSenha,
    float Saldo
);
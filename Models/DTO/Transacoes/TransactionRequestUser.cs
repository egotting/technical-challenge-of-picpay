using System.ComponentModel.DataAnnotations;

namespace Models.DTO;

public record TransactionRequestUser(
    [Required(ErrorMessage = "Precisa ter um valor"), MinLength(3, ErrorMessage = ""),EmailAddress(ErrorMessage = "Isso n é um email")]
    string EmailRemetente, 
    [Required(ErrorMessage = "Precisa ter um valor"), MinLength(3, ErrorMessage = ""),EmailAddress(ErrorMessage = "Isso n é um email")]
    string EmailRecebedor, 
    [Required(ErrorMessage = "Precisa ter um valor")]
    [Range(0.01, double.MaxValue, ErrorMessage = "O preço deve ser um valor positivo")]
    float Valor);
using System.ComponentModel.DataAnnotations;

namespace Models.DTO;

public record TransactionRequestLogista(
    [Required(ErrorMessage = "Precisa por o nome do recebedor")]
    string EmailRemetente,
    [Required(ErrorMessage = "Precisa por o nome do recebedor"), ]
    string CnpjRecebedor,
    [Required(ErrorMessage = "Precisa por a quantia que ira ser transferida")]
    [Range(0.01, double.MaxValue, ErrorMessage = "O preço deve ser um valor positivo")]
    float QuantiaTransferida
);

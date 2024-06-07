using System.ComponentModel.DataAnnotations;
using technical_challenge_of_picpay.Validations;

namespace Models.DTO;

public record TransacoesRequestLogista(
    [Required(ErrorMessage = "Precisa por o nome do recebedor")]
    string EmailRemetente,
    [Required(ErrorMessage = "Precisa por o nome do recebedor"), ValidateCnpj(ErrorMessage = "Este cnpj n existe ou esta escrito errado") ]
    string CnpjRecebedor,
    [Required(ErrorMessage = "Precisa por a quantia que ira ser transferida")]
    float QuantiaTransferida
);

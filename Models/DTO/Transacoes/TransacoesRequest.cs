using System.ComponentModel.DataAnnotations;

namespace Models.DTO;

public record TransacoesRequest(
    [Required(ErrorMessage = "Precisa por o nome do remetente")]
    string NomeDoRemetente,
    [Required(ErrorMessage = "Precisa por o nome do recebedor")]
    string NomeDoRecebedor,
    [Required(ErrorMessage = "Precisa por a quantia que ira ser transferida")]
    float QuantiaTransferida
);
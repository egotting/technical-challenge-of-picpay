using System.ComponentModel.DataAnnotations;

namespace Models.DTO;

public record TransacoesRequestLogista(
    [Required(ErrorMessage = "Precisa por o nome do remetente")]
    string NomeDoRemetente,
    [Required(ErrorMessage = "Precisa por o nome do recebedor")]
    string NomeDoRecebedorLogista,
    [Required(ErrorMessage = "Precisa por o nome do recebedor")]
    string NomeDoRecebedorUsuario,
    [Required(ErrorMessage = "Precisa por a quantia que ira ser transferida")]
    float QuantiaTransferida
);
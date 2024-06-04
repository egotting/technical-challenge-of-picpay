namespace Models.DTO;

public record TransacoesResponse(
    string NomeDoRemetente,
    string NomeDoRecebedor,
    float QuantiaTransferida);
using System.ComponentModel.DataAnnotations;

namespace Models;

public class Transacao
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "Precisa por o nome do remetente")]
    public string NomeDoRemetente { get; set; }
    
    [Required(ErrorMessage = "Precisa por o nome do recebedor")]
    public string NomeDoRecebedor { get; set; }
    
    [Required(ErrorMessage = "Precisa por a quantidade que sera transferida")]
    public float QuantiaTransferida { get; set; }
    public DateTime HoraDoEnvio { get; set; }

    public Transacao(string nomeDoRemetente, string nomeDoRecebedor, float quantiaTransferida)
    {
        NomeDoRemetente = nomeDoRemetente;
        NomeDoRecebedor = nomeDoRecebedor;
        QuantiaTransferida = quantiaTransferida;
        HoraDoEnvio = DateTime.Now;
    }
}
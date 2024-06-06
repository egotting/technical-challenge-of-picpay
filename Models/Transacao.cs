using System.ComponentModel.DataAnnotations;

namespace Models;

public class Transacao
{
    [Key] public int Id { get; set; }

    [Required(ErrorMessage = "Precisa por o nome do remetente")]
    public string EmailDoRemetente { get; set; }

    [Required(ErrorMessage = "Precisa por o nome do recebedor")]
    public string EmailDoRecebedorUsuario { get; set; }

    [Required(ErrorMessage = "Precisa por o nome do recebedor")]
    public string EmailDoRecebedorLogista { get; set; }

    [Required(ErrorMessage = "Precisa por a quantidade que sera transferida")]
    public float QuantiaTransferida { get; set; }

    public DateTime HoraDoEnvio { get; set; }


    public Transacao()
    {
    }

    public Transacao(string emailDoRemetente, string emailDoRecebedorUsuario, string emailDoRecebedorLogista,
        float quantiaTransferida)
    {
        EmailDoRemetente = emailDoRemetente;
        EmailDoRecebedorUsuario = emailDoRecebedorUsuario;
        EmailDoRecebedorLogista = emailDoRecebedorLogista;
        QuantiaTransferida = quantiaTransferida;
        HoraDoEnvio = DateTime.Now;
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

public class Usuario
{
    [Key] public int Id { get; set; }

    public Guid PId { get; set; }

    [Required(ErrorMessage = "precisa de um valor", AllowEmptyStrings = false)]
    public string FullName { get; set; }


    [Required(ErrorMessage = "precisa de um valor", AllowEmptyStrings = false)]
    public string Cpf_Cnpj { get; set; }

    [Required(ErrorMessage = "precisa de um valor", AllowEmptyStrings = false)]
    public string Email { get; set; }

    [Required(ErrorMessage = "precisa de um valor", AllowEmptyStrings = false)]
    public string Senha { get; set; }

    public float Saldo { get; set; }

    public Guid Chave { get; set; }

    public Usuario()
    {
    }

    public Usuario(int id, string fullName, string cpf_Cnpj,
        string email, string senha, float saldo)
    {
        Id = id;
        PId = Guid.NewGuid();
        FullName = fullName;
        Cpf_Cnpj = cpf_Cnpj;
        Email = email;
        Senha = senha;
        Saldo = saldo;
        Chave = Guid.NewGuid();
    }
}
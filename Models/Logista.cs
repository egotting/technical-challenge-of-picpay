using System.ComponentModel.DataAnnotations;

namespace Models;

public class Logista
{
    [Key] public int Id { get; set; }


    [Required(ErrorMessage = "precisa de um valor", AllowEmptyStrings = false)]
    public string FullName { get; set; }


    [Required(ErrorMessage = "precisa de um valor", AllowEmptyStrings = false)]
    public string Cnpj { get; set; }

    [Required(ErrorMessage = "precisa de um valor", AllowEmptyStrings = false)]
    public string Email { get; set; }

    [Required(ErrorMessage = "precisa de um valor", AllowEmptyStrings = false)]
    public string Senha { get; set; }

    public float Saldo { get; set; }


    public Logista()
    {
    }

    public Logista(string fullName, string cnpj,
        string email, string senha, float saldo)
    {
        FullName = fullName;
        Cnpj = cnpj;
        Email = email;
        Senha = senha;
        Saldo = saldo;
    }
}
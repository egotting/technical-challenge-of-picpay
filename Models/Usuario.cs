using System.ComponentModel.DataAnnotations;

namespace Models;

public class Usuario
{
    [Key] public int Id { get; set; }


    [Required(ErrorMessage = "precisa de um valor", AllowEmptyStrings = false)]
    public string FullName { get; set; }


    [Required(ErrorMessage = "precisa de um valor", AllowEmptyStrings = false)]
    public string Cpf { get; set; }

    [Required(ErrorMessage = "precisa de um valor", AllowEmptyStrings = false)]
    public string Email { get; set; }

    [Required(ErrorMessage = "precisa de um valor", AllowEmptyStrings = false)]
    public string Senha { get; set; }

    public float Saldo { get; set; }


    public Usuario()
    {
    }

    public Usuario( string fullName, string cpf,
        string email, string senha, float saldo)
    {
        FullName = fullName;
        Cpf = cpf;
        Email = email;
        Senha = senha;
        Saldo = saldo;
    }
}
using System.ComponentModel.DataAnnotations;

namespace Models;


public class Usuario
{
  [Key]
  public int Id { get; set; }

  [Required(ErrorMessage = "precisa de um valor", AllowEmptyStrings = false)]
  public string FullName { get; set; }


  [Required(ErrorMessage = "precisa de um valor", AllowEmptyStrings = false)]
  public string Cpf_Cnpj { get; set; }

  [Required(ErrorMessage = "precisa de um valor", AllowEmptyStrings = false)]
  public string Email { get; set; }

  [Required(ErrorMessage = "precisa de um valor", AllowEmptyStrings = false)]
  public string Senha { get; set; }

  public float Saldo { get; set; }

  public Usuario(int id, string fullName, string cpf_Cnpj,
      string email, string senha, float saldo)
  {
    Id = id;
    FullName = fullName;
    Cpf_Cnpj = cpf_Cnpj;
    Email = email;
    Senha = senha;
    Saldo = saldo;
  }
}

using Models;

public interface IValidateCpf
{
    public bool ValidCnpj(string cpf);
    public string RemoveIsNotNumeric(string txt);
}
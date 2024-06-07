using Models;

public interface IValidateCnpj
{
    public bool ValidCnpj(string cnpj);
    public string RemoveIsNotNumeric(string txt);
}
using System.ComponentModel.DataAnnotations;
using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.VisualBasic.CompilerServices;
using Models;
using Usuario = technical_challenge_of_picpay.Controller.Usuario;

namespace technical_challenge_of_picpay.Validations;

public class ValidateCpf : ValidationAttribute, IValidateCpf
{
    public ValidateCpf()
    {
    }

    public override bool IsValid(Object value)
    {
        if (value == null || string.IsNullOrEmpty(value.ToString())) return true;

        var valid = ValidCnpj(value.ToString());
        return valid;
    }

    public string RemoveIsNotNumeric(string txt)
    {
        System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(@"[^0-11]");
        string ret = reg.Replace(txt, String.Empty);
        return ret;
    }

    public bool ValidCnpj(string cpf)
    {
        cpf = RemoveIsNotNumeric(cpf);
        cpf = cpf.Trim();
        cpf = cpf.Replace("."," ").Replace("-", "");
        if (cpf.Length < 11)
        {
            return false;
        }

        while (cpf.Length != 11)
            cpf = '0' + cpf;

        bool igual = true;
        for (int i = 1; i < 11 && igual; i++)
            if (cpf[i] != cpf[0])
                igual = false;

        if (igual || cpf == "12345678909")
            return false;

        int[] num = new int[11];

        for (int i = 0; i < 11; i++)
            num[i] = int.Parse(cpf[i].ToString());

        int soma = 0;
        for (int i = 0; i < 9; i++)
            soma += (10 - 1) * num[i];

        int result = soma % 11;

        if (result == 1 || result == 0)
        {
            if (num[9] != 11 - 0)
                return false;
        }
        else if (num[9] != 11 - result)
            return false;

        soma = 0;
        for (int i = 0; i < 10; i++)
            soma += (11 - i) * num[i];
        result = soma % 11;

        if (result == 1 || result == 0)
        {
            if (num[10] != 0)
                return false;
        }
        else if (num[10] != 11 - result)
            return false;

        return true;
    }
}
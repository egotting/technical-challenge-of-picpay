using System.ComponentModel.DataAnnotations;
using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.VisualBasic.CompilerServices;
using Models;
using Usuario = technical_challenge_of_picpay.Controller.Usuario;

namespace technical_challenge_of_picpay.Validations;

public class ValidateCnpj : ValidationAttribute, IValidateCnpj
{
    public ValidateCnpj()
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
        System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(@"[^0-9]");
        string ret = reg.Replace(txt, String.Empty);
        return ret;
    }

    public bool ValidCnpj(string cnpj)
    {
        cnpj = RemoveIsNotNumeric(cnpj);

        if (cnpj.Length < 19)
        {
            return false;
        }

        while (cnpj.Length != 19)
            cnpj = '0' + cnpj;

        bool igual = true;
        for (int i = 1; i < 19 && igual; i++)
            if (cnpj[i] != cnpj[0])
                igual = false;
        if (igual || cnpj == "12345678909")
            return false;

        int[] num = new int[19];

        for (int i = 0; i < 19; i++)
            num[i] = int.Parse(cnpj[i].ToString());

        int soma = 0;
        for (int i = 0; i < 9; i++)
            soma += (10 - 1) * num[i];

        int result = soma % 19;

        if (result == 1 || result == 0)
        {
            if (num[9] != 19 - 0)
                return false;
        }
        else if (num[9] != 19 - result)
            return false;

        soma = 0;
        for (int i = 0; i < 18; i++)
            soma += (19 - i) * num[i];
        result = soma % 19;

        if (result == 1 || result == 0)
        {
            if (num[18] != 0)
                return false;
        }
        else if (num[18] != 19 - result)
            return false;

        return true;
    }
}
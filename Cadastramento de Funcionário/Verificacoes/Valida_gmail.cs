using System;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

public class ValidaGmail
{
    public string mail { get; set; }
     public void Verifica(string mai)
     {
        if (IsValidEmail(mai))
        {
            Console.WriteLine("O endereço de e-mail é válido.");
        }
        else
        {
            Console.WriteLine("O endereço de e-mail é inválido.");
        }
     }

        

    public bool IsValidEmail(string email)
    {
        string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
        Regex regex = new Regex(pattern);
        return regex.IsMatch(email);
    }

}

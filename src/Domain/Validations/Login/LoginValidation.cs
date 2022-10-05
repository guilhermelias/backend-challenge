using System.Text.RegularExpressions;

namespace Domain.Validations.Login
{
    public class LoginValidation
    {
        public bool ValidarSenha(string senha)
        {
            bool minimoCaracters = Regex.IsMatch(senha, @"[!@#$%^&*()-+a-zA-Z0-9]{9,}");
            bool caractersUnicos = Regex.IsMatch(senha, @"^(?:([!@#$%^&*()-+a-zA-Z0-9])(?!.*\1))*$");

            if (minimoCaracters == true && caractersUnicos == true)
                return true;
            else
                return false;
        }
    }
}

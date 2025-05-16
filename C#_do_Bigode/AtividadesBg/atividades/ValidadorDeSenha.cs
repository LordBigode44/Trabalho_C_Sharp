using System;
using System.Text.RegularExpressions;

namespace AtividadeAvalitiva
{
    public static class ValidadorDeSenha
    {
        public static void Executar()
        {
            Console.Write("Digite uma senha: ");
            string senha = Console.ReadLine();

            bool tamanho = senha.Length >= 8;
            bool maiuscula = Regex.IsMatch(senha, "[A-Z]");
            bool numero = Regex.IsMatch(senha, "[0-9]");
            bool especial = Regex.IsMatch(senha, @"[!@#$%\^&*()_\-+=\[\]{}|;:',.<>?/`~]");

            if (tamanho && maiuscula && numero && especial)
                Console.WriteLine("Senha forte!");
            else
                Console.WriteLine("Senha fraca!");
        }
    }
}

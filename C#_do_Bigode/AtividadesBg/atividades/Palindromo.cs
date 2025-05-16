using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace AtividadeAvalitiva
{
    public static class Palindromo
    {
        public static void Executar()
        {
            Console.Write("Digite uma palavra ou frase: ");
            string entrada = Console.ReadLine().ToLower();
            string limpo = Regex.Replace(entrada, "[^a-z0-9]", "");
            string reverso = new string(limpo.Reverse().ToArray());

            Console.WriteLine(limpo == reverso ? "É um palíndromo." : "Não é um palíndromo.");
        }
    }
}

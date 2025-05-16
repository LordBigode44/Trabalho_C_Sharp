using System;

namespace AtividadeAvalitiva
{
    public static class Adivinhacao
    {
        public static void Executar()
        {
            Random rnd = new Random();
            int numero = rnd.Next(1, 101);
            int tentativa, tentativas = 0;

            do
            {
                Console.Write("Adivinhe o número (1-100): ");
                tentativa = int.Parse(Console.ReadLine());
                tentativas++;

                if (tentativa < numero) Console.WriteLine("Maior!");
                else if (tentativa > numero) Console.WriteLine("Menor!");
                else Console.WriteLine($"Acertou em {tentativas} tentativas!");
            } while (tentativa != numero);
        }
    }
}

using System;

namespace AtividadeAvalitiva
{
    public static class Fatorial
    {
        public static void Executar()
        {
            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());
            int resultado = 1;

            while (n > 1)
            {
                resultado *= n;
                n--;
            }

            Console.WriteLine("Fatorial: " + resultado);
        }
    }
}

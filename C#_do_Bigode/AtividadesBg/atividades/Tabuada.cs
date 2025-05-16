using System;

namespace AtividadeAvalitiva
{
    public static class Tabuada
    {
        public static void Executar()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }
}

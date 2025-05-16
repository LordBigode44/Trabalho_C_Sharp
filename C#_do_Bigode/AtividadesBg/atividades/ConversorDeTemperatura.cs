using System;

namespace AtividadeAvalitiva
{
    public static class ConversorDeTemperatura
    {
        public static void Executar()
        {
            int opcao;
            do
            {
                Console.WriteLine("\n1 - Celsius para Fahrenheit");
                Console.WriteLine("2 - Fahrenheit para Celsius");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Celsius: ");
                        double c = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Fahrenheit: {c * 9 / 5 + 32}");
                        break;
                    case 2:
                        Console.Write("Fahrenheit: ");
                        double f = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Celsius: {(f - 32) * 5 / 9}");
                        break;
                    case 3:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            } while (opcao != 3);
        }
    }
}

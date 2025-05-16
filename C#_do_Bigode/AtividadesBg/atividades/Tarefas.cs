using System;
using System.Collections.Generic;

namespace AtividadeAvalitiva
{
    public static class Tarefas
    {
        public static void Executar()
        {
            List<string> tarefas = new List<string>();
            string opcao;

            do
            {
                Console.Write("Digite uma tarefa (ou 'sair' para encerrar): ");
                opcao = Console.ReadLine();
                if (opcao.ToLower() != "sair") tarefas.Add(opcao);
            } while (opcao.ToLower() != "sair");

            Console.WriteLine("Tarefas adicionadas:");
            foreach (var t in tarefas)
                Console.WriteLine("- " + t);
        }
    }
}

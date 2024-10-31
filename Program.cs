using System;

namespace GerenciadorDeTarefas
{
    class Program
    {
        // Lista para armazenar tarefas
        static List<string> tarefas = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao gerenciador de tarefas!");

            while (true)
            {
                // Exibir o menu principal
                Console.WriteLine("\nSelecione uma opção:");
                Console.WriteLine("1. Adicionar tarefa");
                Console.WriteLine("2. Listar tarefas");
                Console.WriteLine("3. Remover tarefa");
                Console.WriteLine("4. Sair");

                string opcao = Console.ReadLine();

                // Processa a opção selecionada pelo usuário
                switch (opcao)
                {
                    case "1":
                        AdicionarTarefa();
                        break;
                    case "2":
                        ListarTarefas();
                        break;
                    case "3":
                        RemoverTarefa();
                        break;
                    case "4":
                        Console.WriteLine("Saindo...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente.");
                        break;
                }
            }
        }

        // Método para adicionar uma tarefa
        static void AdicionarTarefa()
        {
            Console.WriteLine("Digite a descriçao da tarefa:");
            string descricao = Console.ReadLine();
            tarefas.Add(descricao);
            Console.WriteLine("Tarefa Adicionada!");
        }

        // Método para listar todas as tarefas
        static void ListarTarefas()
        {
            Console.WriteLine("\nTarefas:");
            if (tarefas.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa encontrada.");
            }
            else
            {
                for (int i = 0; i < tarefas.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tarefas[i]}");
                }
            }
        }

        static void RemoverTarefa()
        {
            ListarTarefas();
            Console.WriteLine("\nDigite o número da tarefa que deseja remover:");
            if (int.TryParse(Console.ReadLine(), out int numero) && numero > 0 && numero < tarefas.Count)
            {
                tarefas.RemoveAt(numero - 1);
                Console.WriteLine("Tarefa removida!");
            }
            else
            {
                Console.WriteLine("Número inválido");
            }
        }
    }
}
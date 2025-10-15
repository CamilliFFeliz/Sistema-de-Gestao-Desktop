using System;
using SysInventor.Data;
using SysInventor.Services;
using SysInventor.Models;

namespace SysInventor
{
    internal static class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Database.InitializeDatabase();
            Seeder.SeedIfEmpty(100);
            var service = new ProdutoService();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Sistema de Inventário - Gestão de Inventário Desktop ===");
                Console.WriteLine("1. Listar produtos");
                Console.WriteLine("2. Adicionar produto");
                Console.WriteLine("3. Editar produto");
                Console.WriteLine("4. Excluir produto");
                Console.WriteLine("5. Buscar por nome");
                Console.WriteLine("6. Exportar CSV");
                Console.WriteLine("7. Sair");
                Console.Write("Escolha uma opção: ");
                var key = Console.ReadLine();
                Console.WriteLine();

                try
                {
                    switch (key)
                    {
                        case "1":
                            service.ListarProdutos();
                            break;
                        case "2":
                            service.AdicionarProdutoInteractive();
                            break;
                        case "3":
                            service.EditarProdutoInteractive();
                            break;
                        case "4":
                            service.ExcluirProdutoInteractive();
                            break;
                        case "5":
                            service.BuscarPorNomeInteractive();
                            break;
                        case "6":
                            service.ExportarCsv();
                            break;
                        case "7":
                            return;
                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }

                Console.WriteLine("\nPressione ENTER para continuar...");
                Console.ReadLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos vendedores gostaria de adicionar? ");
            int qtdVendedor = int.Parse(Console.ReadLine());

            List<Vendedor> lista = new List<Vendedor>();

            for (int i = 0; i < qtdVendedor; i++)
            {
                Console.WriteLine($"Vendedor #{i + 1}");
                
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), NumberFormatInfo.InvariantInfo);

                Vendedor vendedor = new Vendedor(id, nome, salario);
                lista.Add(vendedor);
                Console.WriteLine();
            }

            Console.Write("Entre com o ID do vendedor que tera o salário aumentado: ");
            int idAumentoSalario = int.Parse(Console.ReadLine());

            Console.Write("Entre com o percentual de aumento: ");
            double percentualAumento = double.Parse(Console.ReadLine(), NumberFormatInfo.InvariantInfo);

            Console.WriteLine();

            Vendedor vendedorAumento = new Vendedor();
            vendedorAumento = lista.Find(x => x.Id == idAumentoSalario);
            vendedorAumento.AumentaSalario(vendedorAumento, percentualAumento);

            Console.WriteLine("Lista atualizada dos funcionários: ");
            foreach (var vendedor in lista)
            {
                Console.WriteLine(vendedor);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using TudoUmPouco.Geral;

namespace TudoUmPouco
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando List
            var listaDeViagem = new List<Produtos>();

            // Instanciando "produtos" da Lista
            var viagem1 = new Produtos();
            var viagem2 = new Produtos();
            var viagem3 = new Produtos();

            // "Populando" os campos dos objetos
            viagem1.Pais = "Canada";
            viagem1.Cidade = "Vancouver";
            viagem1.Valor = 2000.65;

            viagem2.Pais = "Portugal";
            viagem2.Cidade = "Lisboa";
            viagem2.Valor = 3150.70;

            viagem3.Pais = "Estados Unidos";
            viagem3.Cidade = "Los Angeles";
            viagem3.Valor = 4200.20;

            // Adicionando as "instancias produtos" a lista
            listaDeViagem.Add(viagem1);
            listaDeViagem.Add(viagem2);
            listaDeViagem.Add(viagem3);

            Console.WriteLine("1 - ordenar por Pais");
            Console.WriteLine("2 - ordenar por Cidade");
            Console.WriteLine("3 - ordenar por Valor");
            int x = int.Parse(Console.ReadLine());

            while (x != 1 && x != 2 && x != 3)
            {
                Console.WriteLine("Digite novamente");
                Console.WriteLine("1 - ordenar por Pais");
                Console.WriteLine("2 - ordenar por Cidade");
                Console.WriteLine("3 - ordenar por Valor");
                x = int.Parse(Console.ReadLine());
            }

            if (x==1)
            {
                // Imprimindo lista
                var ViagemOrgenada = listaDeViagem.OrderBy(ordenando => ordenando.Pais);
            
                foreach (var viagem in ViagemOrgenada)
                {
                    Console.WriteLine($"Pais:{viagem.Pais}, Cidade:{viagem.Cidade} e Custo:{viagem.Valor}");
                }
            }
            else if (x == 2)
            {
                var ViagemOrgenada = listaDeViagem.OrderBy(ordenando => ordenando.Cidade);

                foreach (var viagem in ViagemOrgenada)
                {
                    Console.WriteLine($"Cidade:{viagem.Cidade}, Pais:{viagem.Pais} e Custo:{viagem.Valor}");
                    Console.WriteLine();
                }
            }
            else if (x == 3)
            {
                var ViagemOrgenada = listaDeViagem.OrderBy(ordenando => ordenando.Valor);

                foreach (var viagem in ViagemOrgenada)
                {
                    Console.WriteLine($"Custo:{viagem.Valor}, Cidade:{viagem.Cidade} e Pais:{viagem.Pais}");
                }
            }

            Console.WriteLine("========================================");

            Funcionarios novoFuncionadio = new Funcionarios();

            Console.Write("Digite o CPF: ");
            string cpf = Console.ReadLine();

            while (cpf.Length != 11)
            {
                Console.Write("Digite o CPF corretamente: ");                                
                cpf = Console.ReadLine();
            }
            novoFuncionadio.UsuarioCPF(cpf);
            Console.WriteLine("========================================");

            Console.Write("Digite o Salario para reajuste salarial: ");
            double salario = double.Parse(Console.ReadLine());
            novoFuncionadio.AumentoSalarial(salario);
            Console.WriteLine("========================================");
            
            Console.ReadLine();
        }
    }
}

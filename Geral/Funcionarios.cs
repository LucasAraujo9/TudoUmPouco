using System;

namespace TudoUmPouco.Geral
{
    public class Funcionarios
    {
        //public Guid Matricula { get; set; }
        public string Nome { get; set; }        
        public string CPF { get; set; }
        public double Salario { get; set; }

        //public Funcionarios(){}

        public void UsuarioNome(string nome)
        {
            Console.WriteLine(nome);
        }
        public void UsuarioCPF(string cpf)
        {
            // Quero fazer validação por caso a pessoa digite letra
            cpf = Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
            Console.WriteLine("Seu CPF: " + cpf);
        }                

         public void AumentoSalarial(double salario)// Reajuste e Salario dps do reajuste
        {
            double reajuste;
            if (salario <= 1100.00)
            {                
                reajuste = salario;
                reajuste *= 0.15;
                salario *= 1.15;
                Console.WriteLine("Aumento de 15%");                
            }
            else if (salario <= 2200.00)
            {
                reajuste = salario;
                reajuste *= 0.10;
                salario *= 1.10;                
                Console.WriteLine("Aumento de 10%");
            }
            else if (salario <= 3000.00)
            {
                reajuste = salario;
                reajuste *= 0.07;
                salario *= 1.07;
                Console.WriteLine("Aumento de 5%");
            }
            else 
            {
                reajuste = salario;
                reajuste *= 0.05;
                salario *= 1.05;                
                Console.WriteLine("Aumento de 5%");
            }
            Console.WriteLine($"Reajuste de R${reajuste.ToString("F2")}");
            Console.WriteLine($"Salario atualizado: R${salario.ToString("F2")}");
        }
        
    }
}

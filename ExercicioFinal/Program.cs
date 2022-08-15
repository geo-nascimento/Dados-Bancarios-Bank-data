using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Declarar o objeto*/
            ContaBancaria conta; /*Declarei fora para não dar problema de escopo com a estutura if else*/

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n): ");
            char resposta = char.Parse(Console.ReadLine());
            Console.WriteLine();

            if (resposta == 's' || resposta == 'S')
            {
                Console.WriteLine("Entre com o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new ContaBancaria(numero, titular, depositoInicial); /*Instanciar o objeto com o construtor personalizado*/
            }
            else
            {
                conta = new ContaBancaria(numero, titular); /*Instanciar o objeto com o construtor personalizado*/
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre com o valor do depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);   
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);
            Console.WriteLine(conta);

                   
        }
    }
}

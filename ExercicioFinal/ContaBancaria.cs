using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioFinal
{
    internal class ContaBancaria
    {
        /*Atributos com auto properties*/
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; } //o private set impede a mudança direta, mas permite a mudança via métodos de classe//

        /*construtures*/
        public ContaBancaria (int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            /*Saldo = saldo; essa atribuição é possivel, mas seria melhor usar o método deposito, pois ele comtem a logica de deposito*/
            Deposito(depositoInicial);
        }
        
        /*Métodos de classe*/
        public void Deposito(double quantia)
        {
            Saldo = Saldo + quantia;
        }

        public void Saque(double quantia)
        {
            double taxa = 5.0;
            Saldo = Saldo - (quantia + taxa);
        }


        /*Método To.String()*/
        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}

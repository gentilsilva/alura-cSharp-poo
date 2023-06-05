using csharp_exception.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exception.Contas
{
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }

        public static float TaxaDeOperacao { get; set; }

        public static float TaxaOperacao { get; private set; }

        private int numeroAgencia;
        public int NumeroAgencia
        {
            get { return numeroAgencia; }
            private set
            {
                if (value > 0)
                {
                    numeroAgencia = value;
                }
            }
        }


        public string Conta { get; set; }

        private double saldo = 100;

        public Cliente Titular { get; set; }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }

        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return saldo;
        }

        public ContaCorrente(int numero_agencia, string numero_conta)
        {
            NumeroAgencia = numero_agencia;
            Conta = numero_conta;

            TaxaDeOperacao = 10 / TotalDeContasCriadas;

            TotalDeContasCriadas++;
        }


    }
}

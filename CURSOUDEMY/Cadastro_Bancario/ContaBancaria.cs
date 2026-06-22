using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course
{
    internal class ContaBancaria
    {
        //definição dos atributos da classe 
        public string Nome { get; private set; }
        public string NumeroConta { get; private set; }
        public double Saldo { get; private set; }

        //Construtor 1 = permite a entrada do número da conta e nome do titular, apenas
        public ContaBancaria(string numeroConta, string nome)
        {
            Nome = nome;
            NumeroConta = numeroConta;
        }
        //Construtor 2 = herda os parâmetros do método 1 e adiciona o depositoInicial
        public ContaBancaria(string numeroConta, string nome, double depositoInicial)
            : this(numeroConta, nome)
        {
            Saldo = depositoInicial;
        }
        //Método que permite depositar um valor
        public void Depositar(double deposito)
        {
            Saldo += deposito;
        }
        //Método que permite sacar um valor
        public void Sacar(double saque)
        {
            double taxa = 5;
            double valorTotal = saque + taxa;
            Saldo -= valorTotal; 

        }
        //Mensagem padrão dos dados da conta
        public override string ToString()
        {
            return $"Conta {NumeroConta}, Titular: {Nome}, Saldo: $ {Saldo.ToString("F2")}";
        }
    }
}

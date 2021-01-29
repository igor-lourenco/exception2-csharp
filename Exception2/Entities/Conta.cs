using Exception2.Entities.Exception;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exception2.Entities {
    class Conta {

        public int Numero { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public double LimiteSaque { get; set; }

        public Conta(int numero, string nome, double saldo, double limiteSaque) {
            Numero = numero;
            Nome = nome;
            Saldo = saldo;
            LimiteSaque = limiteSaque;
        }

        public void Deposito(double montante) {
             Saldo += montante;
        }

        public void Saque(double montante) {

            if (montante > Saldo)
                throw new DominioException("A quantia de saque excedeu o limite");
            if (montante > LimiteSaque)
                throw new DominioException("Conta nao tem saldo");
            Saldo -= montante;
        }

        public override string ToString() {
            return "Nome: " + Nome + " Saldo atual -> " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

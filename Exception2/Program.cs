using Exception2.Entities;
using Exception2.Entities.Exception;
using System;
using System.Globalization;

namespace Exception2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite os dados da conta:");
            Console.Write("Numero: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Saldo inicial: ");
            double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Limite de Saque: ");
            double limite = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Conta conta = new Conta(num, nome, saldo, limite);

            Console.WriteLine();
            Console.Write("Digite a quantia para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try {
                conta.Saque(saque);
                Console.WriteLine(conta);
            }
            catch(DominioException e) {
                Console.WriteLine("Erro no saque: " + e.Message);
            }
        }
    }
}

using System;
using System.Threading;
using DesafioProjetoHospedagem.Models;

namespace DesafioProjetoHospedagem
{
    class Program
    {
    static void Main()
    {
        var historico = new HistoricoReservas();
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("=== Bem-vindo(a) ao Resort Solari ===");
            Console.WriteLine("\"Viva o agora, respire o sempre\"\n");
            Console.WriteLine("=== Sistema de Reservas ===\n");
            Console.WriteLine("1. Fazer nova reserva");
            Console.WriteLine("2. Ver resumo das reservas");
            Console.WriteLine("3. Sair");
            Console.Write("\nEscolha uma opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    FazerNovaReserva(historico);
                    break;
                case "2":
                    Console.Clear();
                    historico.ExibirResumo();
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
                case "3":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("\nOpção inválida!");
                    Thread.Sleep(1500);
                    break;
            }
        }
    }

    static void FazerNovaReserva(HistoricoReservas historico)
    {
        try
        {
            Console.Clear();
            Console.WriteLine("=== Nova Reserva ===\n");

            // Criar suíte
            Console.Write("Tipo da suíte: ");
            string tipoSuite = Console.ReadLine();

            Console.Write("Capacidade da suíte: ");
            if (!int.TryParse(Console.ReadLine(), out int capacidade) || capacidade <= 0)
                throw new Exception("Capacidade inválida!");

            Console.Write("Valor da diária: R$ ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal valorDiaria) || valorDiaria <= 0)
                throw new Exception("Valor da diária inválido!");

            var suite = new Suite(tipoSuite, capacidade, valorDiaria);

            // Dias da reserva
            Console.Write("\nQuantos dias de reserva? ");
            if (!int.TryParse(Console.ReadLine(), out int dias) || dias <= 0)
                throw new Exception("Quantidade de dias inválida!");

            var reserva = new Reserva(suite, dias);

            // Cadastrar hóspedes
            var hospedes = new List<Pessoa>();
            Console.Write("\nQuantos hóspedes? ");
            if (!int.TryParse(Console.ReadLine(), out int numHospedes) || numHospedes <= 0)
                throw new Exception("Quantidade de hóspedes inválida!");

            for (int i = 0; i < numHospedes; i++)
            {
                Console.WriteLine($"\nHóspede {i + 1}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Sobrenome: ");
                string sobrenome = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(sobrenome))
                    throw new Exception("Nome e sobrenome são obrigatórios!");

                hospedes.Add(new Pessoa(nome, sobrenome));
            }

            reserva.CadastrarHospedes(hospedes);
            historico.AdicionarReserva(reserva);

            Console.WriteLine("\nReserva realizada com sucesso!");
            Console.WriteLine($"Valor total: R$ {reserva.CalcularValorDiaria():F2}");
            if (dias >= 10)
                Console.WriteLine("(Desconto de 10% aplicado)");

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nErro: {ex.Message}");
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            }
}    }
}

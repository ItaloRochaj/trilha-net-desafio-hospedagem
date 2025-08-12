using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioProjetoHospedagem.Models
{
    public class HistoricoReservas
    {
        private List<Reserva> reservas = new();

        public void AdicionarReserva(Reserva reserva)
        {
            reservas.Add(reserva);
        }

        public List<Reserva> ListarReservas()
        {
            return reservas;
        }

        public decimal CalcularFaturamentoTotal()
        {
            return reservas.Sum(r => r.CalcularValorDiaria());
        }

        public void ExibirResumo()
        {
            Console.WriteLine("\n📋 RESUMO DAS RESERVAS:");
            Console.WriteLine("═════════════════════════════════════════════");
            foreach (var reserva in reservas)
            {
                Console.WriteLine(reserva.ObterResumo());
            }

            Console.WriteLine($"\n💰 Faturamento total: R$ {CalcularFaturamentoTotal():F2}");
        }
    }
}

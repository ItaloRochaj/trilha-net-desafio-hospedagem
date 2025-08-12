using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public Reserva() { }

        public Reserva(Suite suite, int diasReservados)
        {
            Suite = suite;
            DiasReservados = diasReservados;
        }

        public List<Pessoa> Hospedes { get; private set; } = new();
        public Suite Suite { get; private set; }
        public int DiasReservados { get; private set; }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite == null)
                throw new Exception("Suite não cadastrada.");

            if (hospedes.Count > Suite.Capacidade)
                throw new Exception("Capacidade da suíte excedida.");

            Hospedes = hospedes;
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes() => Hospedes.Count;

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;
            if (DiasReservados >= 10)
                valor *= 0.9M; // 10% de desconto

            return valor;
        }

        public string ObterResumo()
        {
            var hospedesNomes = string.Join(", ", Hospedes.Select(h => $"{h.Nome} {h.Sobrenome}"));
            return $"Suíte: {Suite.TipoSuite} | Dias: {DiasReservados} | Valor: R$ {CalcularValorDiaria():F2}\n" +
                   $"Hóspedes ({ObterQuantidadeHospedes()}): {hospedesNomes}";
        }
    }
}

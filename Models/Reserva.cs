using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count() <= Suite.Capacidade)
            {
                Hospedes = hospedes;
                Console.WriteLine("\ncadastro de hospedes realizado com sucesso\n".ToUpper());
            }
            else
            {
                throw new Exception("\nquantidade de hospedes ultrapassa limite permitido pela suíte.\n".ToUpper());
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                decimal desconto = valor * 0.10m;
                valor = valor - desconto;
            }

            return valor;
        }
    }
}
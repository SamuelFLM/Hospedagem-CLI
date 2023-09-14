
using Hospedagem.Models;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa("Samuel");
Pessoa p2 = new Pessoa("Lima");

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 4, valorDiaria: 200.00m);

hospedes.Add(p1);
hospedes.Add(p2);

Reserva reserva = new Reserva(diasReservados: 10);

reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);


Console.WriteLine($"Quantidade Hospedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Tipo Suite: {suite.TipoSuite}");
Console.WriteLine($"Capacidade: {suite.Capacidade}");
Console.WriteLine($"Valor Diaria: {suite.ValorDiaria:C}");
Console.WriteLine($"Dias Reservados: {reserva.DiasReservados}");
Console.WriteLine($"Valor Total a pagar: {reserva.CalcularValorDiaria():C2}\n");
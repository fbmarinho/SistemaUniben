using System;

namespace SistemaUniben.Domain.Entities
{
	public class Cliente
	{
		public int ClienteId { get; set; }
		public string Nome { get; set; }
		public string Sobrenome { get; set; }
		public DateTime DataCadastro { get; set; }
	}
}
using System;

namespace SistemaUniben.Domain.Entities
{
	public class Telefone
	{
		public Telefone()
		{
			TelefoneId = Guid.NewGuid();
		}

		//Endereço
		public Guid TelefoneId { get; set; }
		public string Tipo { get; set; }
		public string DDD { get; set; }
		public string Numero { get; set; }
		
		public Guid OwnerId { get; set; }

		//Interno
		public bool Ativo { get; set; }
		public bool IsValid { get; set; }
		public DateTime DataCadastro { get; set; }
		public DateTime? DataExclusao { get; set; }

		public string NumeroCompleto()
		{
			return DDD + Numero;
		}
	}
}
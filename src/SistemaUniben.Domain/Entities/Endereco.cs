using System;

namespace SistemaUniben.Domain.Entities
{
	public class Endereco
	{
		public Endereco()
		{
			EnderecoId = new Guid();
		}

		//Endereço
		public Guid EnderecoId { get; set; }
		public string Tipo { get; set; }
		public string CEP { get; set; }
		public string Logradouro { get; set; }
		public string Numero { get; set; }
		public string Complemento { get; set; }
		public string Bairro { get; set; }
		public string Cidade { get; set; }
		public string Estado { get; set; }

		public Guid OwnerId { get; set; }

		//Interno
		public bool Ativo { get; set; }
		public bool IsValid { get; set; }
		public DateTime DataCadastro { get; set; }
		public DateTime? DataExclusao { get; set; }
	}
}
using System;
using System.Text;

namespace SistemaUniben.Domain.Entities
{
	public class Operadora
	{
		public int OperadoraId { get; set; }
		public string CNPJ { get; set; }
		public string Nome { get; set; }
		public string NomeFantasia { get; set; }
		public string Situacao { get; set; }
		public string Telefone { get; set; }
		public string Email { get; set; }
		public DateTime? DataAbertura { get; set; }
		public string NaturezaJuridica { get; set; }
		public string Atividade { get; set; }
		public string Codigo { get; set; }

		//Endereço
		public string CEP { get; set; }
		public string Logradouro { get; set; }
		public string Numero { get; set; }
		public string Complemento { get; set; }
		public string Bairro { get; set; }
		public string Cidade { get; set; }
		public string Estado { get; set; }

		//Interno
		public bool Ativo { get; set; }
		public DateTime DataCadastro { get; set; }
		public DateTime? DataExclusao { get; set; }

	}
}
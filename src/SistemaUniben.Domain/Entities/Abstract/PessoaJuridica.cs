using System;
using System.Collections.Generic;

namespace SistemaUniben.Domain.Entities.Abstract
{
	public abstract class PessoaJuridica
	{
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
		public Guid EnderecoPadrao { get; set; }
		public virtual ICollection<Endereco> Enderecos { get; set; }

		//Interno    
		public bool Ativo { get; set; }
		public DateTime DataCadastro { get; set; }
		public DateTime? DataExclusao { get; set; }
	}
}
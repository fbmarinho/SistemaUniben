using System;

namespace SistemaUniben.Domain.Entities
{
	public class Produto
	{
		public Produto()
		{
			ProdutoId = Guid.NewGuid();
		}

		public Guid ProdutoId { get; set; }
		public string Nome { get; set; }
		public string Termo { get; set; }
		public string Modalidade { get; set; }
		public DateTime DataReajuste { get; set; }
		public string ReajusteOperadora { get; set; }
		public Operadora Operadora { get; set; }
		public string Valor { get; set; }
		public string Onservacao { get; set; }

		//Interno
		public bool Ativo { get; set; }
		public bool IsValid { get; set; }
		public DateTime DataCadastro { get; set; }
		public DateTime? DataExclusao { get; set; }
	}
}
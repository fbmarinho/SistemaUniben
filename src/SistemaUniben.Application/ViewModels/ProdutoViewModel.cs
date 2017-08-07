using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaUniben.Application.ViewModels
{
	public class ProdutoViewModel
	{
		public ProdutoViewModel()
		{
			ProdutoId = Guid.NewGuid();
		}

		[Key]
		public Guid ProdutoId { get; set; }

		public string Nome { get; set; }

		//ANS
		public string NumeroRegistro { get; set; }
		public string Sigla { get; set; }
		public DateTime DataRegistro { get; set; }

		//Financeiro
		public float Valor { get; set; }
		public int PorcentagemPrimeiraMensalidade { get; set; }

		//Segmentacao assistencial
		public string TipoContratacao { get; set; }
		public string AbrangenciaGeografica { get; set; }
		public string Acomodacao { get; set; }
		public bool Coparticipacao { get; set; }

		//Outros
		public string GrauParentescoPermitido { get; set; }
		public string Observacao { get; set; }

		public DateTime DataCadastro { get; set; }
	}
}
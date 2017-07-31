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

		//ANS
		public string NumeroRegistro { get; set; }
		public string Sigla { get; set; }
		public DateTime DataRegistro { get; set; }

		//Financeiro
		public int Valor { get; set; }
		public int PorcentagemPrimeiraMensalidade { get; set; }

		//Segmentacao assistencial
		public string TipoContratacao { get; set; }
		public string AbrangenciaGeografica { get; set; }
		public string Acomodacao { get; set; }
		public bool Coparticipacao { get; set; }

		//Outros
		public string Observacao { get; set; }

		//Interno
		public bool Ativo { get; set; }
		public bool IsValid { get; set; }
		public DateTime DataCadastro { get; set; }
		public DateTime? DataExclusao { get; set; }



			


		
			

			
			

			
	}
}
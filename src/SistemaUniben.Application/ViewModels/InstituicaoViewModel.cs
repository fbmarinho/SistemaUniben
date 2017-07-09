using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SistemaUniben.Application.ViewModels.AbstractViewModels;

namespace SistemaUniben.Application.ViewModels
{
	public class InstituicaoViewModel : PessoaJuridicaViewModel
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int OperadoraId { get; set; }
		
	}
}
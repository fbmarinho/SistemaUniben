using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaUniben.Application.ViewModels
{
	public class ClienteViewModel
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid ClienteId { get; set; }

		[Required(ErrorMessage = "Preencha o campo")]
		[MaxLength(200, ErrorMessage = "Máximo {0} caracteres")]
		[MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
		public string Nome { get; set; }

		[Required(ErrorMessage = "Preencha o campo")]
		[MaxLength(200, ErrorMessage = "Máximo {0} caracteres")]
		[MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
		public string Sobrenome { get; set; }

		[ScaffoldColumn(false)]
		public DateTime DataCadastro { get; set; }
	}
}
using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaUniben.Application.ViewModels.AbstractViewModels
{
	public class PessoaJuridicaViewModel
	{
		[Required(ErrorMessage = "Preencha o campo")]
		[MaxLength(15, ErrorMessage = "Máximo {0} caracteres")]
		[MinLength(14, ErrorMessage = "Mínimo {0} caracteres")]
		public string CNPJ { get; set; }

		[Required(ErrorMessage = "Preencha o campo")]
		[MaxLength(200, ErrorMessage = "Máximo {0} caracteres")]
		[MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
		public string Nome { get; set; }

		[Required(ErrorMessage = "Preencha o campo")]
		[MaxLength(200, ErrorMessage = "Máximo {0} caracteres")]
		[MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
		public string NomeFantasia { get; set; }

		[Required(ErrorMessage = "Preencha o campo")]
		[MaxLength(200, ErrorMessage = "Máximo {0} caracteres")]
		public string Situacao { get; set; }

		[Required(ErrorMessage = "Preencha o campo")]
		[MaxLength(11, ErrorMessage = "Máximo {0} caracteres")]
		[MinLength(10, ErrorMessage = "Mínimo {0} caracteres")]
		public string Telefone { get; set; }

		[Required(ErrorMessage = "Preencha o campo")]
		[EmailAddress(ErrorMessage = "Preencha com um e-mail válido")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Preencha o campo")]
		[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
		public DateTime DataAbertura { get; set; }

		[Required(ErrorMessage = "Preencha o campo")]
		[MaxLength(200, ErrorMessage = "Máximo {0} caracteres")]
		[MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
		public string NaturezaJuridica { get; set; }

		[Required(ErrorMessage = "Preencha o campo")]
		[MaxLength(200, ErrorMessage = "Máximo {0} caracteres")]
		[MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
		public string Atividade { get; set; }

		[Required(ErrorMessage = "Preencha o campo")]
		[MaxLength(200, ErrorMessage = "Máximo {0} caracteres")]
		[MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
		public string Codigo { get; set; }

		//Endereço
		[Required(ErrorMessage = "Preencha o campo")]
		[MaxLength(8, ErrorMessage = "Máximo {0} caracteres")]
		[MinLength(8, ErrorMessage = "Mínimo {0} caracteres")]
		public string CEP { get; set; }

		[Required(ErrorMessage = "Preencha o campo")]
		[MaxLength(200, ErrorMessage = "Máximo {0} caracteres")]
		public string Logradouro { get; set; }

		[Required(ErrorMessage = "Preencha o campo")]
		[MaxLength(10, ErrorMessage = "Máximo {0} caracteres")]
		[MinLength(1, ErrorMessage = "Mínimo {0} caracteres")]
		public string Numero { get; set; }

		[Required(ErrorMessage = "Preencha o campo")]
		[MaxLength(30, ErrorMessage = "Máximo {0} caracteres")]
		public string Complemento { get; set; }

		[Required(ErrorMessage = "Preencha o campo")]
		[MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
		public string Bairro { get; set; }

		[Required(ErrorMessage = "Preencha o campo")]
		[MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
		public string Cidade { get; set; }

		[Required(ErrorMessage = "Preencha o campo")]
		[MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
		public string Estado { get; set; }
	}
}
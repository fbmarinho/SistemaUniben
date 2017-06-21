using System.Text;

namespace SistemaUniben.Domain.Entities
{
	public class Operadora
	{
		public int OperadoraId { get; set; }
		public string CNPJ { get; set; }
		public string Nome { get; set; }
		public TYPE Type { get; set; }
	}
}
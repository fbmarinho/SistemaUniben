using System.Threading.Tasks;
using Correios.CorreiosServiceReference;

namespace SistemaUniben.Infra.Data.Interfaces
{
	public interface IUtil
	{
		Task<enderecoERP> BuscarEnderecoPorCEP(string cep);
	}
}
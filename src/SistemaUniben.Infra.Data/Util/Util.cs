using System.Threading.Tasks;
using Correios;
using Correios.CorreiosServiceReference;
using SistemaUniben.Infra.Data.Interfaces;

namespace SistemaUniben.Infra.Data.Util
{
	public class Util : IUtil
	{
		public async Task<enderecoERP> BuscarEnderecoPorCEP(string cep)
		{

			//Assincrono
			var service = new CorreiosApi();
			var dados = (await service.consultaCEPAsync(cep)).@return;
			return dados;
		}
	}
}
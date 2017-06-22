using System.Net;
using System.Web;
using SistemaUniben.Infra.Data.Interfaces;

namespace SistemaUniben.Infra.Data.Context
{
	public class ContextManager : IContextManager
	{
		private const string ContextKey = "ContextManager.Context";
		public SistemaUnibenContext GetContext()
		{
			if (HttpContext.Current.Items[ContextKey] == null)
			{
				HttpContext.Current.Items[ContextKey] = new SistemaUnibenContext();
			}
			return (SistemaUnibenContext) HttpContext.Current.Items[ContextKey];
		}
	}
}
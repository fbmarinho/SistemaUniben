﻿using SistemaUniben.Domain.Entities;

namespace SistemaUniben.Domain.Interfaces.Services
{
	public interface IOperadoraService : IBaseService<Operadora>, IPessoaJuridicaService<Operadora>
	{
		// Métodos específicos
	}
}
﻿using SistemaUniben.Domain.Entities;

namespace SistemaUniben.Domain.Interfaces.Repositories
{
	public interface IInstituicaoRepository : IBaseRepository<Instituicao>, IPessoaJuridicaRepository<Instituicao>
	{
		//Métodos específicos
	}
}
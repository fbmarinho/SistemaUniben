using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using SistemaUniben.Domain.Entities;
using SistemaUniben.Domain.Interfaces.Repositories;
using SistemaUniben.Domain.Interfaces.Services;

namespace SistemaUniben.Domain.Services
{
	public class ClienteService : IClienteService
	{

		protected readonly IClienteRepository _clienteRepository;

		public ClienteService(IClienteRepository clienteRepository)
		{
			_clienteRepository = clienteRepository;
		}

		public void Adicionar(Cliente obj)
		{
			_clienteRepository.Add(obj);
		}

		public void Atualizar(Cliente obj)
		{
			_clienteRepository.Update(obj);
		}

		public IEnumerable<Cliente> Buscar(Expression<Func<Cliente, bool>> predicate)
		{
			return _clienteRepository.Find(predicate).ToList();
		}

		public void Dispose()
		{
			_clienteRepository.Dispose();
		}

		public Cliente ObterPorId(Guid id)
		{
			return _clienteRepository.GetById(id);
		}

		public IEnumerable<Cliente> ObterPorNome(string nome)
		{
			return _clienteRepository.GetByName(nome);
		}

		public IEnumerable<Cliente> ObterTodos()
		{
			return _clienteRepository.GetAll();
		}

		public void Remover(Cliente obj)
		{
			_clienteRepository.Remove(obj);
		}
	}
}
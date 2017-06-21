﻿using System;
using System.Collections.Generic;
using AutoMapper;
using SistemaUniben.Application.Interfaces;
using SistemaUniben.Application.ViewModels;
using SistemaUniben.Domain.Entities;
using SistemaUniben.Domain.Interfaces.Services;

namespace SistemaUniben.Application
{
	public class ClienteAppService : IClienteAppService
	{

		private readonly IClienteService _clienteService;

		public ClienteAppService(IClienteService clienteService)
		{
			_clienteService = clienteService;
		}

		public void Adicionar(ClienteViewModel obj)
		{
			var cliente = Mapper.Map<ClienteViewModel, Cliente>(obj);

			_clienteService.Adicionar(cliente);
		}

		public ClienteViewModel ObterPorId(int id)
		{
			var cliente = _clienteService.ObterPorId(id);
			return Mapper.Map<Cliente, ClienteViewModel>(cliente);
		}

		public IEnumerable<ClienteViewModel> ObterTodos()
		{
			var todos = _clienteService.ObterTodos();
			return Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(todos); ;
		}

		public void Atualizar(ClienteViewModel obj)
		{
			var cliente = Mapper.Map<ClienteViewModel, Cliente>(obj);
			_clienteService.Atualizar(cliente);
		}

		public void Remover(ClienteViewModel obj)
		{
			var cliente = Mapper.Map<ClienteViewModel, Cliente>(obj);
			_clienteService.Remover(cliente);
		}

		public IEnumerable<ClienteViewModel> ObterPorNome(string nome)
		{
			var clientes = _clienteService.ObterPorNome(nome);
			return Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(clientes); ;
		}

		public void Dispose()
		{
			_clienteService.Dispose();
			GC.SuppressFinalize(this);
		}
	}
}
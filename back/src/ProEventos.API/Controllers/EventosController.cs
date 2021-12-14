﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.data;
using ProEventos.API.models;

namespace ProEventos.API.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class EventosController : ControllerBase
	{
		private readonly DataContext _context;

		public EventosController(DataContext context)
		{
			this._context = context;

		}

		[HttpGet]
		public IEnumerable<Evento> Get()
		{
			return  _context.Eventos;

		}

		[HttpGet("{id}")]
		public Evento GetbyId(int id)
		{
			return  _context.Eventos.FirstOrDefault(evento =>evento.EventoID == id);

		}


		[HttpPost]
		public string Post()
		{
			return "Exemplo Post";

		}
	}
}

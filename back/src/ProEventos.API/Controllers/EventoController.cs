using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        
        public EventoController()
        {
        }

        [HttpGet]
        public Evento Get()
        {
            return new Evento(){
                EventoID = 1,
                Tema = "Asp net"
            };
            
        }

       [HttpPost]
        public string Post()
        {
            return "Exemplo Post";
            
        }
    }
}

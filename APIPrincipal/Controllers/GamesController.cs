using APIPrincipal.DTOs;
using APIPrincipal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using APIPrincipal.Configuration;
using Microsoft.Extensions.Options;

namespace APIPrincipal.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class GamesController : ControllerBase
    {
        IMapper _mapper;
        MyAppSettings _myAppSettings;

        public GamesController(IMapper mapper, IOptions<MyAppSettings> myAppSettings)
        {
            _mapper = mapper;
            _myAppSettings = myAppSettings.Value;
        }

        [HttpGet]
        public IActionResult CadastrarGame(GamesRequestDto req)
        {
            var game = _mapper.Map<Games>(req);

            //Recuperando valores do appsettings.json: https://www.notion.so/Configura-es-de-Projetos-NET-d0d90bf7718e44f29e71f49aca8d5e0d
            var teste =_myAppSettings.Mauricio;

            return Ok( game );
        }
    }
}

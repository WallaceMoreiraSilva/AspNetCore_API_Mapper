using AspNetCore_API_Mapper.DTOs;
using AspNetCore_API_Mapper.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_API_Mapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionariosController : ControllerBase
    {
        private readonly IMapper _mapper;

        public FuncionariosController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Post(Funcionario func)
        {
            var funcionarioDTO = _mapper.Map<FuncionarioDTO>(func);

            return Ok(funcionarioDTO);
        }
    }
}

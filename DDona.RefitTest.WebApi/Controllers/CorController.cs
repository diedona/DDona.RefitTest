using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDona.RefitTest.Domain.Entities;
using DDona.RefitTest.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDona.RefitTest.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CorController : ControllerBase
    {
        private readonly ICorRepository _corRepository;

        public CorController(ICorRepository corRepository)
        {
            _corRepository = corRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Cor>> Get()
        {
            return Ok(_corRepository.CarregarTodos());
        }

        [Route("{id}")]
        [HttpGet]
        public ActionResult<Cor> Get(int id)
        {
            return Ok(_corRepository.CarregarPorId(id));
        }
    }
}
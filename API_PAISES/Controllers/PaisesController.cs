using System;
using System.Collections.Generic;
using System.Linq;
using API_PAISES.Data;
using API_PAISES.Model;
using Microsoft.AspNetCore.Mvc;

namespace API_PAISES.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaisesController : ControllerBase
    {
        private PaisesContex _context;

        public PaisesController(PaisesContex context)

        {
            _context = context;
        }

        public object GetPaisesById { get; private set; }

        [HttpGet]
        public IActionResult AddPaises([FromBody] Paises paises)
        {
            _context.paises.Add(paises);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetPaisesById), new { Id = paises.Id }, paises);
        }

        [HttpGet] 
        public IEnumerable<Paises> GetPaises() 
        {

            return _context.paises;

        }

    }

}

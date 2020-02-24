using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PokedexConsole.Entities;
namespace PokedexAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BerriesController : ControllerBase
    {
        private readonly PokedexContext _context;

        public BerriesController(PokedexContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Berries>>> GetBerries() {
            return await _context.Berries.ToListAsync();
        }
    }
}
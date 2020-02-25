using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PokedexConsole.Entities;
using PokedexConsole.DTO;
using System.Linq;
namespace PokedexAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypesController : ControllerBase
    {
        private readonly PokedexContext _context;
        public TypesController(PokedexContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TypesDTO>>> GetTypes()
        {
            return await _context.Types.Select(x => TypesToDTO(x)).ToListAsync();
        }
        private static TypesDTO TypesToDTO(Types type) =>
            new TypesDTO
            {
                Id = type.Id,
                Identifier = type.Identifier
            };
    }
}
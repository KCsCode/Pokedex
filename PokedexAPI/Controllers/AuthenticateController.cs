using Microsoft.AspNetCore.Mvc;
using PokedexAPI.Model;
using PokedexConsole.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PokedexAPI.DTO;
using PokedexAPI.Utility;

namespace PokedexAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly PokedexContext _context;
        public AuthenticateController(PokedexContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Login(UserRequestDTO request)
        {
            Users user = null;
            IActionResult response = Unauthorized();
            PasswordManager pm = new PasswordManager();
            
            user = _context.Users.FirstOrDefault(x => x.UserName == request.UserName);
            if (user != null)
            {
                if (pm.VerifyPassword(request.Password, user.Password))
                {
                    response = Ok(JwtManager.GenerateJSONToken(user.UserName));
                }

            }

            return response;
        }

    }
}
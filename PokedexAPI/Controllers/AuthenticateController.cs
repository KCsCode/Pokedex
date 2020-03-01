using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PokedexAPI.Utility;
using PokedexDTOs.RequestDTO;
using PokedexPersistance.Entities;

namespace PokedexAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly PokedexContext _context;
        private readonly JwtManager _jwtManager;
        private readonly PasswordManager _passwordManager;

        /// <summary>
        /// Creates a new instance of the <see cref="AuthenticateController"/> class.
        /// </summary>
        public AuthenticateController(PokedexContext context, JwtManager jwtManager, PasswordManager passwordManager)
        {
            _context = context;
            _jwtManager = jwtManager;
            _passwordManager = passwordManager;
        }

        /// <summary>
        /// 
        /// </summary>
        [Route("v1/verify-user")]
        [HttpPost]
        public IActionResult Login(UserRequestDTO request)
        {
            Users user = null;
            IActionResult response = Unauthorized();
            
            user = _context.Users.FirstOrDefault(x => x.UserName == request.UserName);
            if (user != null)
            {
                if (_passwordManager.VerifyPassword(request.Password, user.Password))
                {
                    response = Ok(_jwtManager.GenerateJSONToken(user.UserName));
                }

            }

            return response;
        }

    }
}
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CoreEditor.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreEditor.Controllers
{
    public class AuthController : Controller
    {
        private readonly CoreEditorContext _context;

        public AuthController(CoreEditorContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("Login, Password")] AuthViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _context.Users
                .Where(u => u.Login == model.Login && u.PasswordHash == CoreEditor.Models.User.HashPassword(model.Password))
                .FirstOrDefaultAsync();

                if (user != null)
                {
                    await Authenticate(model.Login);
                    return Redirect("../Home/Index");
                }
                else
                {
                    ModelState.AddModelError(
                        string.Empty,
                        "Неверное имя пользователя или пароль"
                    );
                }

                await _context.SaveChangesAsync();
            }
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("../Home/Index");
        }

        private async Task Authenticate(string login)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, login)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
    }
}

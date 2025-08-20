using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WebPhim.Models;
using WebPhim.Repositories.Interfaces;

namespace WebPhim.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUserRepository _userRepository;

        public AuthController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // GET: Register
        [HttpGet]
        public IActionResult Register() => View();

        // POST: Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var existing = _userRepository.GetUserByEmail(model.Email);
            if (existing != null)
            {
                ModelState.AddModelError("", "Email đã tồn tại!");
                return View(model);
            }

            var user = new User(model.UserName, model.Email);
            _userRepository.Register(user, model.Password);

            TempData["SuccessMessage"] = "Đăng ký thành công, mời bạn đăng nhập!";
            return RedirectToAction("Login");
        }

        // GET: Login
        [HttpGet]
        public IActionResult Login() => View(new LoginViewModel());

        // POST: Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var user = _userRepository.GetUserByEmail(model.Email);

            if (user == null || !_userRepository.CheckPassword(user, model.Password))
            {
                ModelState.AddModelError("", "Email hoặc mật khẩu không đúng!");
                return View(model);
            }

            // Tạo claims
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName??String.Empty),
                new Claim(ClaimTypes.Email, user.Email??"Uknown"),
                new Claim(ClaimTypes.NameIdentifier,user.UserID??String.Empty)
            };

            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity));

            return RedirectToAction("Index", "Home");
        }

        // GET: Logout
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }

    }
}

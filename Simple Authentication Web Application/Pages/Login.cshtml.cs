using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Simple_Authentication_Web_Application.Model;
using Simple_Authentication_Web_Application.ViewModels;

namespace Simple_Authentication_Web_Application.Pages
{
    public class LoginModel : PageModel
    {

        private readonly AuthDbContext _authDbContext;

        [BindProperty]
        public Login Model { get; set; }

        public LoginModel(AuthDbContext authDbContext)
        {
            _authDbContext = authDbContext;
        }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {

            var user = _authDbContext.Users
                .FirstOrDefaultAsync(u => u.UserName == Model.Username && u.PasswordHash == Model.Password);

            if (user != null)
            {
                return RedirectToPage("/Table");
            }

            return RedirectToPage("/index");
        }


    }
}

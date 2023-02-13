using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Simple_Authentication_Web_Application.ViewModels;

namespace Simple_Authentication_Web_Application.Pages
{
    public class LoginModel : PageModel
    {

        public void OnGet()
        {
        }

        public IActionResult OnPost(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return Page();
            }

            // Perform authentication here
            // Need to check if the user exist in the 

            return RedirectToPage("/Index");
        }
    }
}

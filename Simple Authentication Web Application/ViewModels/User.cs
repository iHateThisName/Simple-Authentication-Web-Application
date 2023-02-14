using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Simple_Authentication_Web_Application.ViewModels
{
    public class User
    {
        public string Name { get; set; }
        public DateTime DateJoined { get; set; }
        public string Email { get; set; }
    }

}

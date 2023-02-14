using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Simple_Authentication_Web_Application.ViewModels;

namespace Simple_Authentication_Web_Application.Pages
{

    public class TableModel : PageModel
    {
        public List<User> Users { get; set; }

        public void OnGet()
        {
            // Here i should retrive information about every user from the db
            // and create a for-loop that will add every user to UserList

            Users = new List<User>();

            // but since i am having trouble with the comunication to the database i am using the dummy data that is added below

            Users.Add(new User
            {
                Name = "Chuck Norris",
                DateJoined = DateTime.Now,
                Email = "chuck.norris@mail.com",
            });

            Users.Add(new User
            {
                Name = "Keanu Reeves",
                DateJoined = new DateTime(2021, 1, 1),
                Email = "keanu.reeves@example.com"
            });
        }
    }
}

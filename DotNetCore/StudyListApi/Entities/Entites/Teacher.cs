using Microsoft.AspNetCore.Identity;

namespace Entities.Entites
{
    public class Teacher : IdentityUser
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ImagePath { get; set; }

        public string Gender { get; set; }


    }
}

using Microsoft.AspNetCore.Identity;

namespace DAL.Models
{
    public class Users : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int GroupId { get; set; }

        public Group Group { get; set; }
    }
}

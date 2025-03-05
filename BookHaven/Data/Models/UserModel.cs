using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Data.Models
{
    public class UserModel
    {
        public Guid UserID { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }  
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int RoleID { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

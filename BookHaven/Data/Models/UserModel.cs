using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Data.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string RegistrationNumber { get; set; }  // Corrected from 'ReigstrationNumber'
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }  // Corrected from 'Addres'
        public string Phone { get; set; }
        public int RoleID { get; set; }
        public string Idnumber { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }  // Changed from string to DateTime
        public bool IsDeleted { get; set; }  // Changed from int to bool
        public DateTime CreatedAt { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alomero_Housing_Software.BLL
{
    class UserBLL
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Designation { get; set; }
        public string NationalID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int CreatedBy { get; set; }
        public string Role { get; set; }
    }
}

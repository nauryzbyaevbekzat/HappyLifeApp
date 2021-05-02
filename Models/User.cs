using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyLife.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
          public string Password { get; set; }

        public int? RoleId { get; set; }
        public Role Role { get; set; }

        public List<Record> Records { get; set; } = new List<Record>();

        public List<Accesemp> Accesemps { get; set; } = new List<Accesemp>();

    }
}

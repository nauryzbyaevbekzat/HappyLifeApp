using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyLife.Models
{
    public class Accesemp
    {
        public int Id { get; set; }
       
        public int Other { get; set; }
       
        public string Email { get; set; }

        
        public int UserId { get; set; }
        public User User { get; set; }
    }
}

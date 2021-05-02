using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyLife.Models
{
    public class Record
    {
        public int RecordId { get; set; }
        public string Description { get; set; }
        public bool InWork { get; set; } = false;
        public DateTime Start { get; set; }  
        public DateTime End { get; set; }
        
        public int UserId { get; set; }
        public User User { get; set; }

    }
}

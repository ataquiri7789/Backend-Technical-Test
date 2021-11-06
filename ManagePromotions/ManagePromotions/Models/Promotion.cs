using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagePromotions.Models
{
    public class Promotion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Code { get; set; }
        public int Status { get; set; }
    }
    
}

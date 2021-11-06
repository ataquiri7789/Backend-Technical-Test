using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagePromotions.DTOs.Requests
{
    public class GenerateCodeRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        //public string Code { get; set; }
    }
}

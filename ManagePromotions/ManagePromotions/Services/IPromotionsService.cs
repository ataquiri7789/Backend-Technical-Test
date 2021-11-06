using ManagePromotions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagePromotions.Services
{
    public interface IPromotionsService
    {
        IEnumerable<Promotion> GetAll();
        public void GenerateCode(Promotion promotion);
        IEnumerable<Promotion> UpdateStatus();

    }
}

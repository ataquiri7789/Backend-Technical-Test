using ManagePromotions.Models;
using ManagePromotions.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagePromotions.Services
{
    public class PromotionsService : IPromotionsService
    {
        private readonly ContextDatabase _contextDatabase;

        public PromotionsService(ContextDatabase contextDatabase)
        {
            _contextDatabase = contextDatabase;
        }

        public void GenerateCode(Promotion promotion)
        {
            _contextDatabase.Promotions.Update(promotion);
            _contextDatabase.SaveChanges();
        }

        public IEnumerable<Promotion> GetAll()
        {
            return _contextDatabase.Promotions.ToList();
        }

        public IEnumerable<Promotion> UpdateStatus()
        {
            throw new NotImplementedException();
        }
    }
}

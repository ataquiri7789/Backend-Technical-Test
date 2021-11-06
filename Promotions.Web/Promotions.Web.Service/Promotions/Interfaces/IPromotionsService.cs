using Promotions.Web.DTO.Promotion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotions.Web.Service.Promotions.Interfaces
{
    public interface IPromotionsService
    {
        Task<List<PromotionDTOResponse>> GetAll();
        void GenerateCode(GenerateCodeDTORequest generateCodeDTORequest);

    }
}

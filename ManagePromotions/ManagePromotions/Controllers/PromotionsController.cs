using ManagePromotions.DTOs.Requests;
using ManagePromotions.DTOs.Responses;
using ManagePromotions.Models;
using ManagePromotions.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagePromotions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionsController : ControllerBase
    {
        private readonly IPromotionsService _promotionsService;

        public PromotionsController(IPromotionsService promotionsService)
        {
            _promotionsService = promotionsService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_promotionsService.GetAll());
        }

        [HttpPost("GenerateCode")]
        public IActionResult GenerateCode([FromBody] GenerateCodeRequest request)
        {
            GenerateCodeResponse response = new GenerateCodeResponse();

            var result = _promotionsService.GetAll().Where(x => x.Name.ToLower().Trim() == request.Name.ToLower().Trim()
                                                            && x.Email.ToLower().Trim() == request.Email && x.Status == 0).FirstOrDefault();


            if (result!=null)
            {
                Promotion promotion = new Promotion()
                {
                    Code = Guid.NewGuid().ToString(),
                    Id = result.Id
                };

                _promotionsService.GenerateCode(promotion);
                result.Code = promotion.Code;
                response.Code = String.Format("{0} {1}", "Su código es:", result.Code);
            }
            else
            {
                response.Code = String.Format("{0} ", "Por favor verifique en la pagina principal");
            }

            return Ok(response);
        }


        [HttpPost("Exchange")]
        public IActionResult Exchange([FromBody] GenerateCodeRequest request)
        {
            bool validar = false;
            var result = _promotionsService.GetAll().Where(x => x.Status == 1 /*&& x.Code == request.Code*/).FirstOrDefault();

            if (result!=null)
                validar = true;

            return Ok(validar);
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Promotions.Web.DTO.Promotion;
using Promotions.Web.Service.Promotions.Interfaces;
using Promotions.Web.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Promotions.Web.UI
{
    public class HomeController : Controller
    {
        private readonly IPromotionsService _promotionService;


        public HomeController(IPromotionsService promotionsService)
        {
            _promotionService = promotionsService;
        }

        public ActionResult Index()
        {
            List<Promotion> promotions = new List<Promotion>();

            var result = _promotionService.GetAll().Result;

            foreach (var item in result)
            {
                Promotion promotion = new Promotion();
                promotion.Id = item.Id;
                promotion.Name = item.Name;
                promotion.Email = item.Email;
                promotion.Code = item.Code;
                promotion.Status = item.Status;
                promotions.Add(promotion);
            }    
            return View(promotions);
        }


        [HttpGet]
        public ActionResult Generate()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Prueba()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Generate(GenerateCode generate)
        {
            GenerateCodeDTORequest generateCodeDTORequest = new GenerateCodeDTORequest();
            generateCodeDTORequest.Name = generate.Name;
            generateCodeDTORequest.Email = generate.Email;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44389/api/Promotions/GenerateCode");

                //HTTP POST
                var postTask = client.PostAsJsonAsync<GenerateCodeDTORequest>("GenerateCode", generateCodeDTORequest);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            return View();
        }

        [HttpGet]
        public ActionResult Exchange()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Exchange(Exchange exchange)
        {
            ExchangeDTORequest exchangeDTORequest = new ExchangeDTORequest();
            exchangeDTORequest.Email = exchange.Email;


            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44389/api/Promotions/Exchange");

                //HTTP POST
                var postTask = client.PostAsJsonAsync<ExchangeDTORequest>("Exchange", exchangeDTORequest);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            return View();
        }



    }
}

using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Promotions.Cross.Proxy.Proxy;
using Promotions.Web.DTO.Promotion;
using Promotions.Web.Service.Promotions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotions.Web.Service.Promotions.Implementations
{
    public class PromotionsService : IPromotionsService
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpClient _httpClient;
        public PromotionsService(IHttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async void GenerateCode(GenerateCodeDTORequest generateCodeDTORequest)
        {
            string uri = $"{_configuration["Proxy:UrlCode"]}";
            await _httpClient.PostAsync(uri, generateCodeDTORequest);
        }

        public async Task<List<PromotionDTOResponse>> GetAll()
        {
            string uri = $"{_configuration["Proxy:Url"]}";
            var result = await _httpClient.GetStringAsync(uri, "");
            var response = JsonConvert.DeserializeObject<List<PromotionDTOResponse>>(result);
            return response;
        }
    }
}

using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{


    public class IngressoApiService : IIngressoApiService
    { 
        public async Task<List<MonthModel>> GetMonths(string event_id)
        {
            try
            {
                List<MonthModel> monthModels = new List<MonthModel>();
                RestClient client = new RestClient("https://api.ticketswitch.com");
                RestRequest request = new RestRequest("/f13/months.v1", Method.GET);
                request.AddParameter("event_id", event_id, ParameterType.QueryString);
                byte[] encodedBytes = System.Text.Encoding.UTF8.GetBytes("demo:demopass");
                string encodedTxt = Convert.ToBase64String(encodedBytes);
                request.AddHeader("Authorization", "Basic " + encodedTxt);
                IRestResponse<MonthModel> response = client.Execute<MonthModel>(request);
                var data = response.Content;
                var fullUrl = client.BuildUri(request);
                return monthModels;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

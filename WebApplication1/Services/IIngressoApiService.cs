using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IIngressoApiService
    {
        Task<List<MonthModel>> GetMonths(string event_id);
    }
}

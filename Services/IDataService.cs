using Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Services
{
    public interface IDataService
    {
        Task Create(RequestData request);
        Task<RequestData> Get(string guid);
    }
}

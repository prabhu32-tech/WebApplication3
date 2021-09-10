using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public ValuesController(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetSection("Data").GetSection("ConnectionString").Value;
        }
        
        [HttpGet("Country")]
        public IList<string> GetCountry()
        {
            IList<string> _strList;
            var _repo = new Repo.Sample();
            _strList = _repo.Country(_connectionString);
            return _strList;

        }

        [HttpGet("State")]
        public IList<string> GetState()
        {
            IList<string> _strList;
            var _repo = new Repo.Sample();
            _strList = _repo.State(_connectionString);
            return _strList;

        }

    }
}

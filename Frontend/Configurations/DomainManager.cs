using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Configurations
{
    public class DomainManager : IDomainService
    {
        private IConfiguration _configuration;

        public DomainManager(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string Domain()
        {
            string host = _configuration.GetSection("Host").Value;
            return host;
        }
    }
}

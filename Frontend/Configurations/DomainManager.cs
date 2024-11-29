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
        private IConfiguration Configuration;

        public DomainManager(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public string Domain()
        {
            string host = Configuration.GetSection("Host").Value;
            return host;
        }
    }
}

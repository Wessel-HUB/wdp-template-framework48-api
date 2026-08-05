using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __ProjectName__.Contracts.Requests
{
    public class HealthResponse
    {
        public string Status { get; set; }

        public string Application { get; set; }

        public string Version { get; set; }

        public string Environment { get; set; }

        public string Database { get; set; }

        public DateTime ServerTime { get; set; }

        public string WdpVersion { get; set; }
    }
}

using __ProjectName__.Contracts.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __ProjectName__.Application.Interfaces
{
    public interface IHealthService
    {
        HealthResponse GetHealth();
    }
}

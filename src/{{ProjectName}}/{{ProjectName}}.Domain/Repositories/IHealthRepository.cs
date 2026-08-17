using __ProjectName__.Contracts.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __ProjectName__.Domain.Repositories
{
    public interface IHealthRepository
    {
        DateTime GetServerTime();

        //HealthResponse GetHealth();
    }
}

using System;
using __ProjectName__.Contracts.Requests;
using __ProjectName__.Domain.Repositories;
namespace __ProjectName__.Infrastructure.Repositories
{
    public class HealthRepository : IHealthRepository
    {
        public DateTime GetServerTime()
        {
            return DateTime.Now;
        }

        //public HealthResponse GetHealth()
        //{
        //    return new HealthResponse();
        //}
    }
}

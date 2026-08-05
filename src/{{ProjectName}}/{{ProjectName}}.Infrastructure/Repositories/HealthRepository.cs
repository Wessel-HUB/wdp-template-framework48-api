using System;
using __ProjectName__.Domain.Repositories;
namespace __ProjectName__.Infrastructure.Repositories
{
    public class HealthRepository : IHealthRepository
    {
        public DateTime GetServerTime()
        {
            return DateTime.Now;
        }
    }
}

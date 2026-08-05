using __ProjectName__.Application.Interfaces;
using __ProjectName__.Contracts.Requests;
using __ProjectName__.Domain.Repositories;

namespace __ProjectName__.Application.Services
{
    public class HealthService : IHealthService
    {
        private readonly IHealthRepository _repository;

        public HealthService(IHealthRepository repository)
        {
            _repository = repository;
        }

        public HealthResponse GetHealth()
        {
            return new HealthResponse
            {
                Status = "Healthy",
                Application = "TODO",
                Version = "0.1.0",
                Environment = "Development",
                Database = "Connected",
                ServerTime = _repository.GetServerTime(),
                WdpVersion = "0.1.0"
            };
        }

    }
}

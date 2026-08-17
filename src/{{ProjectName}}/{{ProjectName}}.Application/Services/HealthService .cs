using __ProjectName__.Application.Interfaces;
using __ProjectName__.Contracts.Requests;
using __ProjectName__.Domain.Repositories;

namespace __ProjectName__.Application.Services
{
    public class HealthService : IHealthService
    {
        private readonly IHealthRepository _healthRepository;

        public HealthService(IHealthRepository repository)
        {
            _healthRepository = repository;
        }

        public HealthResponse GetHealth()
        {
            return new HealthResponse
            {
                Application = "WDP API",
                Environment = "Development",
                ServerTime = _healthRepository.GetServerTime(),
                Status = "Healthy",
                Version = "1.0.0",
                WdpVersion = "Foundation 1"
            };
        }

    }
}

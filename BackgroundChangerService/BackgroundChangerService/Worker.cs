using BackgroundChangerService.BackgroundChangers;

namespace BackgroundChangerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> logger;
        private readonly IBackgroundChanger backgroundChanger;

        public Worker(ILogger<Worker> logger)
        {
            this.logger = logger;
            backgroundChanger = new BackgroundChanger();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                logger.LogInformation("Changing background");
                backgroundChanger.ChangeBackground();
                await Task.Delay(10000, stoppingToken);
            }
        }
    }
}
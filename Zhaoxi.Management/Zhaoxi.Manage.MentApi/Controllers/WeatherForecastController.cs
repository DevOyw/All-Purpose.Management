using Microsoft.AspNetCore.Mvc;
using Zhaoxi.Manage.MentApi.Utility.InitDatabaseExt;
using Zhaoxi.Manage.MentApi.Utility.SwaggerExt;

namespace Zhaoxi.Manage.MentApi.Controllers
{
    /// <summary>
    /// ���Կ�����
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    [ApiExplorerSettings(IgnoreApi = false, GroupName = nameof(ApiVersions.V1))]
    [Function(MuType.Page,"���Կ�����")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get����
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "GetWeatherForecast")]
        [Function(MuType.Btn, "Get")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        /// <summary>
        /// Post����
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Function(MuType.Btn, "PostInfo")]
        public IEnumerable<WeatherForecast> PostInfo()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        /// <summary>
        /// Put����
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [Function(MuType.Btn, "Put")]
        public IEnumerable<WeatherForecast> PutInfo()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        /// <summary>
        /// Delete����
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        [Function(MuType.Btn, "DeleteInfo")]
        public IEnumerable<WeatherForecast> DeleteInfo()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
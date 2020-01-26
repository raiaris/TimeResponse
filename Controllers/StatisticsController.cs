using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VideoAPI.Models;
using VideoAPI.Repositories;

namespace VideoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly VideoRepository _repository;

        public StatisticsController(VideoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Statistics>> Get()
        {
            try
            {
                var videos = await _repository.Videos.ToListAsync();


                videos.Where(x => ((DateTime.Now - TimestampToDate(x.Timestamp)).TotalSeconds <= 60));

                Statistics stats = new Statistics()
                {
                    Sum = 0,
                    Avg = 0,
                    Min = 0,
                    Max = 0,
                    Count = 0
                };

                stats.Sum = videos.Sum(x => x.Duration);
                stats.Min = videos.Min(x => x.Duration);
                stats.Max = videos.Max(x => x.Duration);
                stats.Avg = videos.Average(x => x.Duration);
                stats.Count = videos.Count;

                return stats;

            }
            catch (NullReferenceException ex)
            {
                throw ex;
            }
        }

        private DateTime TimestampToDate(long timestamp)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(timestamp).ToLocalTime();
            return dtDateTime;
        }
    }
}

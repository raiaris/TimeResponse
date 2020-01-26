using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VideoAPI.Models;
using VideoAPI.Repositories;
using VideoAPI.Requests;

namespace VideoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoController : ControllerBase
    {
        private readonly VideoRepository _repository;

        public VideoController(VideoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<Video>>> GetAll()
        {
            try
            {
                return await _repository.Videos.ToListAsync();
            } catch(NullReferenceException ex)
            {
                throw ex;
            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Video>> GetById(long id)
        {
            try
            {
                var video = await _repository.Videos.FindAsync(id);

                if (video == null)
                {
                    return NotFound();
                }

                return video;
            } catch(KeyNotFoundException ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Video>> Add(VideoRequest request)
        {
            try
            {
                var date = this.TimestampToDate(request.Timestamp);

                //Transforma o timestamp em DateTime e verifica se é valido
                if(date != null)
                {
                    //Verifica se a diferença do timestamp de postagem do video é menor que 60 segundos
                    var difference = (DateTime.Now - date).TotalSeconds;
                    if(difference <= 60)
                    {
                        var video = new Video()
                        {
                            Title = request.Title,
                            Duration = request.Duration,
                            Timestamp = request.Timestamp
                        };

                        _repository.Videos.Add(video);
                        await _repository.SaveChangesAsync();

                        return CreatedAtAction(nameof(GetById), new { id = video.Id }, video);
                    }
                    return NoContent();
                }
                return NoContent();

            } catch(MissingFieldException ex)
            {
                throw ex;
            }
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Edit(long id, Video video)
        {
            try
            {
                _repository.Entry(video).State = EntityState.Modified;
                await _repository.SaveChangesAsync();

                return CreatedAtAction(nameof(GetById), new { id = video.Id }, video);

            } catch(MissingFieldException ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteAll(long id)
        {
           try
            {
                _repository.Videos.RemoveRange(_repository.Videos);
                await _repository.SaveChangesAsync();

                return NoContent();
            } catch(NullReferenceException ex)
            {
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Delete(long id)
        {
            try
            {
                var video = await _repository.Videos.FindAsync(id);

                _repository.Videos.Remove(video);
                await _repository.SaveChangesAsync();

                return NoContent();
            } catch (KeyNotFoundException ex)
            {
                throw ex;
            }
        }

        private DateTime TimestampToDate(long timestamp)
        {
            DateTime dtDateTime = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(timestamp).ToLocalTime();
            return dtDateTime;
        }
    }
}

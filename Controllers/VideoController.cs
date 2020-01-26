using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SolucionarApi.Models;
using SolucionarApi.Repositories.Interfaces;


namespace SolucionarApi.Controllers
{



    [ApiController]
    [Route("/api/[controller]")]
    public class VideoController : Controller
    {
    
        private readonly IVideoRepository _videoRepository;

        public VideoController(IVideoRepository videoRepository)
        {
            _videoRepository = videoRepository;
        }

        [HttpGet]
        [Produces(typeof(Video))]
        public IActionResult GetAllVideos()
        {
            var videos = _videoRepository.GetAll();

            if (videos == null)
            {
                return NoContent();
            }
            else
            {
                return Ok(videos);
            }
        }

        [HttpGet("Video/{id}")]
        public IActionResult GetVideoById(int id)
        {
            var video = _videoRepository;

            if (video == null)
            {
                return NoContent();
            }
            else
            {
                return Ok(video);
            }
        }

        [HttpPost]
        public IActionResult Post(Video video)
        {
            if (video == null)
            {
                return NoContent();
            }
            else
            {
                try
                {
                   _context.Video.Add(Video);
                     await _context.SaveChangesAsync();
                }
                catch
                {
                    throw new NotImplementedException();
                }
            }
        }


        //  [HttpPost]
        // public async Task<ActionResult<Video>> Post(Video video)
        // {
           
        //    try
        //         {
        //              _context.Video.Add(Video);
        //              await _context.SaveChangesAsync();
        //         }
        //         catch
        //         {
        //             throw new NotImplementedException();
        //         }
        // }




        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var video = _videoRepository;

            if (video == null)
            {
                return NoContent();
            }
            else
            {
                return Ok(video);
            }
        }
    }
}

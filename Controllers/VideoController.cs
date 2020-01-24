using System;
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
        public IActionResult GetAllUsuarios()
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

        [HttpGet("{id}")]
        public IActionResult GetUsuarioById(int id)
        {
            var usuario = _videoRepository;

            if (usuario == null)
            {
                return NoContent();
            }
            else
            {
                return Ok(usuario);
            }
        }

        [HttpGet("Video/{id}")]
        public IActionResult GetUsuarioByPessoaId(int id)
        {
            var usuario = _videoRepository;

            if (usuario == null)
            {
                return NoContent();
            }
            else
            {
                return Ok(usuario);
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
                
                return Ok(video);
            }
        }

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

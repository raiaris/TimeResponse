using System;
using System.Collections.Generic;
using SolucionarApi.Models;

namespace SolucionarApi.Repositories.Interfaces
{
    public interface IVideoRepository : IBaseRepository
    {
        IEnumerable<Video> GetAll();
       

        void AddVideo(Video video);
        void RemoveVideos(bool deletar);
    }
}
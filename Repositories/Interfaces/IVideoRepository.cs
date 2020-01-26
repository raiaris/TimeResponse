using System;
using System.Collections.Generic;
using SolucionarApi.Models;

namespace SolucionarApi.Repositories.Interfaces
{
    public interface IVideoRepository : IBaseRepository
    {
        Resposta GetAll();
        void AddVideo(Video video);
        void RemoveVideo(int id);
        int LastIndex();
    }
}
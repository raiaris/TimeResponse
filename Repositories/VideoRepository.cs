using System;
using System.Collections.Generic;
using Dapper;
using MySql.Data.MySqlClient;
using SolucionarApi.Models;
using SolucionarApi.Repositories.Interfaces;

namespace SolucionarApi.Repositories
{

    public class VideoRepository : IVideoRepository
    {

        public VideoRepository()
        {
        }

        public Resposta GetAll()
        {
            try
            {
                Resposta resposta = new Resposta(0, 0, 0, 0, 0);

                foreach (var video in videos)
                {
                    resposta.Sum += video.Duration;
                    resposta.Count++;
                    if (video.Duration > resposta.Max)
                    {
                        resposta.Max = video.Duration;
                    }
                    resposta.Avg = resposta.Sum / videos.Count;
                    resposta.Min = 0;

                }

                return resposta;

            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public void RemoveVideo(int id)
        {
            try
            {
                // videos.RemoveAt(id);
            }
            catch
            {
                throw new NotImplementedException();
            }
        }


        public void AddVideo(Video video)
        {
            try
            {
                _context.Video.Add(Video);
            }
            catch
            {
                throw new NotImplementedException();
            }

        }

        public int LastIndex()
        {
            if (this.videos != null)
            {
                return videos.Count;
            }
            else
            {
                return 0;
            }
        }
    }
}
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
        private readonly string _connectionString;
        private readonly List<Video> videos = new List<Video>();
        public VideoRepository(string conectionString)
        {
            _connectionString = conectionString;
        }

        public IEnumerable<Video> GetAll()
        {
            try
            {
                let total = videos.reduce((total, videos) => total + videos.Duration, 0);

                Resposta resposta = new Resposta();


            }
            catch
            {
                throw new NotImplementedException();
            }
        }



        public void RemovePessoa(bool deletar)
        {
            try
            {
                if (deletar == true)
                {
                    videos.RemoveAll;
                }
            }
            catch
            {

            }
        }


        public void AddVideo(Video video)
        {
            try
            {

                videos.Add(video);
            }
            catch
            {
                throw new NotImplementedException();
            }

        }

    }
}
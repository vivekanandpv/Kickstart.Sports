using Badminton.Service.Extensions;
using Badminton.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Badminton.Service.Services
{
    public interface IPlayerService
    {
        Task<Player> Get(Guid id);
    }

    public class PlayerService : IPlayerService
    {
        private readonly HttpClient _httpClient;

        public PlayerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Player> Get(Guid id)
        {
            var response = await _httpClient.GetAsync($"/api/players/{id}");
            return await response.GetAs<Player>();
        }
    }
}

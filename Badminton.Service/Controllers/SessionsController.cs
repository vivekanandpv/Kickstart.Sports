using Badminton.Service.Models;
using Badminton.Service.Services;
using Badminton.Service.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Badminton.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionsController : ControllerBase
    {
        private readonly IPlayerService _playerService;

        public SessionsController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        //  Start
        [HttpPost("/start")]
        public async Task<IActionResult> Start(SessionStartViewModel viewModel)
        {
            //  player information here from viewModel
            var player = await _playerService.Get(viewModel.PlayerId);

            //  create the session
            var session = new Session
            {
                Player = player,
                Id = Guid.NewGuid(),
                Start = DateTime.UtcNow,
                Remarks = $"Started session for: {player.FirstName} {player.LastName}"
            };

            //  save

            //  return an anonymous object with session id
            return Ok(new { SessionId = session.Id, Remarks = session.Remarks });
        }


        //  End
        [HttpPost("/end")]
        public async Task<IActionResult> End(SessionEndViewModel viewModel)
        {
            //  player information here from viewModel
            var player = await _playerService.Get(Guid.NewGuid());

            //  create the session
            var session = new Session
            {
                Player = player,
                Id = Guid.NewGuid(),
                Start = DateTime.UtcNow.AddHours(-2),
                End = DateTime.UtcNow,
                Remarks = $"Started session for: {player.FirstName} {player.LastName}"
            };

            //  save

            //  return an anonymous object with session id
            return Ok(new { SessionId = session.Id, Remarks = session.Remarks, Start = session.Start, End = session.End });
        }
    }
}

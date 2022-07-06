using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos.Forks;
using API.Models;
using API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ForkController : ControllerBase
    {
        private readonly IForkService _forkService;
        public ForkController(IForkService forkService)
        {
            _forkService = forkService;

        }
        [HttpPost]
        [Route("{id}")]
        public async Task<ActionResult<ServiceResponse<PostForkDto>>> PostFork(PostForkDto newFork, int id)
        {
            return Ok(await _forkService.PostNewFork(newFork, id));
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetForkDto>>>> GetForksByStoryLineId(int id)
        {
            return Ok(await _forkService.GetForksByStoryLineId(id));
        }

    }
}
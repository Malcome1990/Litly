using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos.StoryLine;
using API.Models;
using API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class StoryLineController : ControllerBase
    {
        private readonly IStoryLineService _storyLineService;
        public StoryLineController(IStoryLineService storyLineService)
        {
            _storyLineService = storyLineService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<GetStoryLineDto>>>> GetAllStoryLines()
        {
            return Ok(await _storyLineService.GetAllStoryLines());
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetStoryLineDto>>>> AddStoryLine(PostStoryLineDto addedStoryLine)
        {
            return Ok(await _storyLineService.AddStoryLine(addedStoryLine));
        }

        [HttpGet]
        [Route("user/{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetStoryLineDto>>>> GetStoryLinesByUser(int id)
        {
            return Ok(await _storyLineService.GetAllStoryLinesByUser(id));
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<ServiceResponse<GetStoryLineDto>>> GetStoryLineById(int id)
        {
            return Ok(await _storyLineService.GetStoryLineById(id));
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetStoryLineDto>>>> Delete(int id)
        {
            var response = await _storyLineService.DeleteStoryLine(id);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult<ServiceResponse<GetStoryLineDto>>> UpdateStoryLine(PutStoryLineDto updatedStoryLine)
        {
            var response = await _storyLineService.UpdateStoryLine(updatedStoryLine);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
    }
}
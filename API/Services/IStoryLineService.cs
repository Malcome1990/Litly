using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos.StoryLine;
using API.Models;

namespace API.Services
{
    public interface IStoryLineService
    {
        Task<ServiceResponse<List<GetStoryLineDto>>> GetAllStoryLines();
        Task<ServiceResponse<GetStoryLineDto>> GetStoryLineById(int id);
        Task<ServiceResponse<List<GetStoryLineDto>>> GetAllStoryLinesByUser(int id);
        Task<ServiceResponse<List<GetStoryLineDto>>> AddStoryLine(PostStoryLineDto newStoryLine);
        Task<ServiceResponse<PutStoryLineDto>> UpdateStoryLine(PutStoryLineDto updatedStoryLine);
        Task<ServiceResponse<List<GetStoryLineDto>>> DeleteStoryLine(int id);
    };
}
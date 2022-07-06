using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos.Forks;
using API.Models;

namespace API.Services
{
    public interface IForkService
    {
        Task<ServiceResponse<GetForkDto>> LikeFork(int id);
        Task<ServiceResponse<List<GetForkDto>>> GetForksByStoryLineId(int id);
        Task<ServiceResponse<PostForkDto>> PostNewFork(PostForkDto createdFork, int id);
        Task<ServiceResponse<List<GetForkDto>>> GetPopularForks();
    }
}
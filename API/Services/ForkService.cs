using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using API.Data;
using API.Dtos.Forks;
using API.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class ForkService : IForkService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ForkService(DataContext context, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
            _context = context;

        }

        private int GetUserId() => int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));

        public async Task<ServiceResponse<GetForkDto>> LikeFork(int id)
        {
            var serviceResponse = new ServiceResponse<GetForkDto>();
            var dbFork = await _context.Forks.FirstOrDefaultAsync(f => f.Id == id);
            dbFork.Likes = dbFork.Likes + 1;

            await _context.SaveChangesAsync();
            serviceResponse.Data = _mapper.Map<GetForkDto>(dbFork);
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetForkDto>>> GetForksByStoryLineId(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetForkDto>>();
            var dbForks = await _context.Forks.Where(f => f.StoryLineId == id).ToListAsync();

            serviceResponse.Data = dbForks.Select(f => _mapper.Map<GetForkDto>(f)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetForkDto>>> GetPopularForks()
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<PostForkDto>> PostNewFork(PostForkDto createdFork, int id)
        {
            var serviceResponse = new ServiceResponse<PostForkDto>();
            Fork fork = _mapper.Map<Fork>(createdFork);

            fork.StoryLineId = id;
            fork.UserId = GetUserId();

            _context.Forks.Add(fork);


            await _context.SaveChangesAsync();
            serviceResponse.Data = createdFork;
            return serviceResponse;
        }
    }
}
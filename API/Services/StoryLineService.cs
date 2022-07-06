using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Dtos.StoryLine;
using API.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace API.Services
{
    public class StoryLineService : IStoryLineService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public StoryLineService(DataContext context, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
            _context = context;

        }
        private int GetUserId() => int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
        public async Task<ServiceResponse<List<GetStoryLineDto>>> AddStoryLine(PostStoryLineDto newStoryLine)
        {
            var serviceResponse = new ServiceResponse<List<GetStoryLineDto>>();
            StoryLine storyLine = _mapper.Map<StoryLine>(newStoryLine);
            storyLine.UserId = GetUserId();
            _context.StoryLines.Add(storyLine);
            await _context.SaveChangesAsync();
            serviceResponse.Data = await _context.StoryLines
            .Where(s => s.UserId == GetUserId())
            .Select(s => _mapper.Map<GetStoryLineDto>(s))
            .ToListAsync();

            return serviceResponse;

        }

        public async Task<ServiceResponse<List<GetStoryLineDto>>> DeleteStoryLine(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetStoryLineDto>>();
            try
            {
                StoryLine storyLine = await _context.StoryLines
                .FirstOrDefaultAsync(s => s.Id == id && s.UserId == GetUserId());
                if (storyLine != null)
                {
                    _context.StoryLines.Remove(storyLine);
                    await _context.SaveChangesAsync();

                    serviceResponse.Data = await _context.StoryLines
                    .Where(s => s.UserId == GetUserId())
                    .Select(s => _mapper.Map<GetStoryLineDto>(s)).ToListAsync();
                }
                else
                {
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Story Line not found.";
                }
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetStoryLineDto>>> GetAllStoryLines()
        {
            var serviceResponse = new ServiceResponse<List<GetStoryLineDto>>();
            var dbStoryLines = await _context.StoryLines.ToListAsync();

            serviceResponse.Data = dbStoryLines.Select(s => _mapper.Map<GetStoryLineDto>(s)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetStoryLineDto>> GetStoryLineById(int id)
        {
            var serviceResponse = new ServiceResponse<GetStoryLineDto>();
            var dbStoryLines = await _context.StoryLines.FirstOrDefaultAsync(s => s.UserId == GetUserId() && s.Id == id);

            serviceResponse.Data = _mapper.Map<GetStoryLineDto>(dbStoryLines);
            return serviceResponse;
        }

        public async Task<ServiceResponse<PutStoryLineDto>> UpdateStoryLine(PutStoryLineDto updatedStoryLine)
        {
            var serviceResponse = new ServiceResponse<PutStoryLineDto>();
            try
            {
                StoryLine storyLine = await _context.StoryLines
                .FirstOrDefaultAsync(s => s.Id == updatedStoryLine.Id && s.UserId == GetUserId());
                storyLine.Body = updatedStoryLine.Body;
                storyLine.Likes = updatedStoryLine.Likes;

                await _context.SaveChangesAsync();
                serviceResponse.Data = _mapper.Map<PutStoryLineDto>(storyLine);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetStoryLineDto>>> GetAllStoryLinesByUser(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetStoryLineDto>>();
            serviceResponse.Data = await _context.StoryLines
            .Where(s => s.UserId == GetUserId())
            .Select(s => _mapper.Map<GetStoryLineDto>(s)).ToListAsync();
            return serviceResponse;
        }
    }
}
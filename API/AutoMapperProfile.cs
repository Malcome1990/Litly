using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using API.Dtos.Forks;
using API.Dtos.StoryLine;
using API.Dtos.User;
using API.Models;

namespace API
{
    public class AutoMapperProfile : AutoMapper.Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<StoryLine, GetStoryLineDto>();
            CreateMap<PostStoryLineDto, StoryLine>();
            CreateMap<PutStoryLineDto, StoryLine>();
            CreateMap<StoryLine, PutStoryLineDto>();
            CreateMap<UpdateUserDto, User>();
            CreateMap<User, UpdateUserDto>();
            CreateMap<Fork, PostForkDto>();
            CreateMap<PostForkDto, Fork>();
            CreateMap<Fork, GetForkDto>();
            CreateMap<GetForkDto, Fork>();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos.User;
using API.Models;

namespace API.Services
{
    public interface IUserService
    {
        Task<ServiceResponse<UpdateUserDto>> UpdateUserById(UpdateUserDto updatedUser);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.Dtos.StoryLine
{
    public class PutStoryLineDto
    {
        public string Body { get; set; }
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Likes { get; set; }
    }
}
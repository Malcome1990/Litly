using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class UserLikes
    {
        public int UserLikesId { get; set; }
        public List<int> ThreadLikes { get; set; }
        public List<int> StoryLineLikes { get; set; }
        public List<int> CommentLikes { get; set; }
        public List<int> PostLikes { get; set; }
    }
}
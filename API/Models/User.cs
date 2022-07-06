using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Profile { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public List<StoryLine> StoryLines { get; set; }
        public List<Fork> UserForks { get; set; }
        public List<Comment> UserComments { get; set; }
        public List<Post> UserPosts { get; set; }
    }
}
using LocalMindApi.Models.Users;
using System;

namespace LocalMindApi.Models
{
    public class UserAdditionalDetail
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public string Age { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }

        public Guid UserId { get; set; }
        public User user { get; set; }
    }
}

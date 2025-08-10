using LocalMindApi.Models.Users;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocalMindApi.Models.UserAdditionalDetails
{
    public class UserAdditionalDetail
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public string Age { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }

        [ForeignKey("Users")]
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace LocalMindApi.Models.UserCredentials
{
    public class UserCredential
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
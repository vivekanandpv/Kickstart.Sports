using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Player.Service.Models
{
    public class PlayerEntity
    {
        public Guid PlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public long MobileNumber { get; set; }
        public string ImageUrl { get; set; }
        public string PersonalInformation { get; set; }
    }
}

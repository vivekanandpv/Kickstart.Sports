using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Badminton.Service.Models
{
    public class Player
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalInformation { get; set; }
        public string ImageUrl { get; set; }
    }

    public class Session
    {
        public Guid Id { get; set; }
        public Player Player { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
        public string Remarks { get; set; }
    }
}

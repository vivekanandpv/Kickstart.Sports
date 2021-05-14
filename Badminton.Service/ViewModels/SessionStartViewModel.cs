using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Badminton.Service.ViewModels
{
    public class SessionStartViewModel
    {
        public Guid PlayerId { get; set; }
    }

    public class SessionEndViewModel
    {
        public Guid SessionId { get; set; }
    }
}

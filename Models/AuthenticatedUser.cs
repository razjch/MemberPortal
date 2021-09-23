using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemberPortal.Models
{
    public class AuthenticatedUser
    {
        public string Token { get; set; }
        public int MemberId { get; set; }
        public string Name { get; set; }
    }
}

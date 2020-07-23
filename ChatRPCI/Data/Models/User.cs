using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRPCI
{
    public class User : IdentityUser
    {
        public List<CHsModel> MutedUsers { get; set; }
     
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRPCI
{
    public class CHsModel
    {
        [Key]
        public int id { get; set; }

        public User User { get; set; }
        public string UserId{ get; set; }


        
        public string MutedUserName { get; set; }
        //public User MutedUser { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ChatRPCI.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;

namespace ChatRPCI
{
    public class DialogsModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly IHubContext<DialogHub> hubContex;
        

        public string userName { get; set; }
        public string noFriends { get; set; }
        
        
       public DialogsModel(ApplicationDbContext db, IHubContext<DialogHub> hubContext)
        {
             _context = db;
            this.hubContex = hubContext;
            
            
            
            
        }

       

    }
}
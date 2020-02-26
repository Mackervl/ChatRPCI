using ChatRPCI.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace ChatRPCI
{
    
    [Authorize]
    public class DialogHub : Hub
    {
         ApplicationDbContext _context;
         UserManager<User> _userManager;
       
        public DialogHub(ApplicationDbContext db, UserManager<User> _userManager)
        {
            _context = db;
            this._userManager = _userManager;
           
            
        }
       
        public async Task Send(string message, string takerName)
        {

           
            var caller = Context.User.Identity.Name;

            List<string> items = new List<string>();
            
           
           
            User users = _context.Users.FirstOrDefault(u =>u.UserName == takerName);
            if (users != null)
            {
                _context.Chs.Where(p => p.UserId == users.Id).Load();
                bool flag = false;
                if (users.MutedUsers != null)
                {
                    foreach (var m in users.MutedUsers)
                    {
                        if (m.MutedUserName == caller)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag == false)
                    {
                        await Clients.User(takerName).SendAsync("SendToClient", message, caller);
                        await Clients.Caller.SendAsync("SendToClient", message, caller);
                    }
                    else
                    {
                        string s = "Пользователь заблокировал вас!";
                        await Clients.Caller.SendAsync("SendThatMuted", s);
                    }
                }
                else
                {
                    await Clients.User(takerName).SendAsync("SendToClient", message, caller);
                    await Clients.Caller.SendAsync("SendToClient", message, caller);
                }
            }
            else { await Clients.Caller.SendAsync("InvalidRecp"); }
        }
      
       
    

        
    }
}

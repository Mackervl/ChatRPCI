using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRPCI
{
    public class ChatHub : Hub
    {

       
        public async Task Send(string message)
        {
           /* var user = Context.User;
            var userName = user.Identity.Name;*/
            
            await Clients.All.SendAsync("MessageToClient", message);
        }
    }
}

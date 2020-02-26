using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChatRPCI
{
    public class GeneralChatModel : PageModel
    {
        public string userName { get; set; }
        public void OnGet()
        {
            userName = HttpContext.User.Identity.Name;
        }
    }
}
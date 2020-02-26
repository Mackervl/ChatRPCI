using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ChatRPCI.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ChatRPCI
{
    public class AddMuteModel : PageModel
    {

        public string FAQ { get; set; }
        public List<CHsModel> muteds { get; set; }
        
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; } //second user email
        }

        public AddMuteModel(ApplicationDbContext db, UserManager<User> userManager,
            SignInManager<User> signInManager)
        {
            _context = db;
            _signInManager = signInManager;
            _userManager = userManager;
            
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var muted = await _context.Chs.FindAsync(id);

            if (muted != null)
            {
                _context.Chs.Remove(muted);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
        public void OnGet()
        {

            FAQ = "Add uset in black list using his email.";

            List<CHsModel> items = new List<CHsModel>();
            var id = _userManager.GetUserId(HttpContext.User);
            User users = _context.Users.Find(id);

            _context.Chs.Where(p => p.UserId == users.Id).Load();
            if (users.MutedUsers != null)
            {
                foreach (var m in users.MutedUsers)
                {

                    
                    items.Add(m);
                }


            }
            muteds = items;

        }
       
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {

                var muted_user = await _userManager.FindByNameAsync(Input.Email);
                if (muted_user != null)
                {
                    var id = _userManager.GetUserId(HttpContext.User);


                    if (!_context.Chs.Any(u => u.UserId == id && u.MutedUserName == muted_user.UserName))
                    {
                        var result = new CHsModel { UserId = id, MutedUserName = muted_user.UserName };
                        _context.Chs.AddRange(result);
                        _context.SaveChanges();
                        
                    }
                    else
                    {
                        return NotFound("This user is already muted!");
                    }
                }
                else
                {
                    return NotFound("There is no such user!");

                }
            }
            return Redirect("AddMute");
        }


    }
}

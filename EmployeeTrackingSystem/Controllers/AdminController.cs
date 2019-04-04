using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using EmployeeTrackingSystem.Data;
using EmployeeTrackingSystem.Models;

namespace EmployeeTrackingSystem.Controllers
{
    public class AdminController : Controller
    {
        private ApplicationDbContext _application;
        private readonly UserManager<IdentityUser> _userManager;
        public AdminController(UserManager<IdentityUser> userManager, ApplicationDbContext application)
        {
            _userManager = userManager;
            _application = application;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            ViewData["Message"] = "Admin";
            return View(_application.Users.ToList());
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> MakeUser(string id)
        {
            var user = await _application.Users.FindAsync(id);
            if (await _userManager.IsInRoleAsync(user, "Admin"))
            {
                await _userManager.RemoveFromRoleAsync(user, "Admin");
            }
            else if (await _userManager.IsInRoleAsync(user, "Manager"))
            {
                await _userManager.RemoveFromRoleAsync(user, "Manager");
            }
            else if (await _userManager.IsInRoleAsync(user, "User"))
            {
                await _userManager.RemoveFromRoleAsync(user, "User");
            }
            await _userManager.AddToRoleAsync(user, "User");
            return LocalRedirect("/Admin");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> MakeManager(string id)
        {
            var user = await _application.Users.FindAsync(id);
            if (await _userManager.IsInRoleAsync(user, "Admin"))
            {
                await _userManager.RemoveFromRoleAsync(user, "Admin");
            }
            else if (await _userManager.IsInRoleAsync(user, "Manager"))
            {
                await _userManager.RemoveFromRoleAsync(user, "Manager");
            }
            else if (await _userManager.IsInRoleAsync(user, "User"))
            {
                await _userManager.RemoveFromRoleAsync(user, "User");
            }
            await _userManager.AddToRoleAsync(user, "Manager");
            return LocalRedirect("/Admin");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> MakeAdmin(string id)
        {
            var user = await _application.Users.FindAsync(id);
            if (await _userManager.IsInRoleAsync(user, "Admin"))
            {
                await _userManager.RemoveFromRoleAsync(user, "Admin");
            }
            else if (await _userManager.IsInRoleAsync(user, "Manager"))
            {
                await _userManager.RemoveFromRoleAsync(user, "Manager");
            }
            else if (await _userManager.IsInRoleAsync(user, "User"))
            {
                await _userManager.RemoveFromRoleAsync(user, "User");
            }
            await _userManager.AddToRoleAsync(user, "Admin");
            return LocalRedirect("/Admin");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Lock(string id)
        {
            var user = await _application.Users.FindAsync(id);
            if(await _userManager.IsLockedOutAsync(user) == true)
            {
                await _userManager.SetLockoutEndDateAsync(user, DateTime.Today);
            }
            else
            {
                await _userManager.SetLockoutEndDateAsync(user, DateTime.Now.AddYears(100));
            }
            return LocalRedirect("/Admin");
        }
    }
}
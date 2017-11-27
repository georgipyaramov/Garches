using Garches.Data;
using Garches.Web.Models.PagesViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garches.Web.Controllers
{
    public class PagesController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public PagesController(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public IActionResult Page(string pageName)
        {
            var page = dbContext.Pages
                .Include(x => x.Articles)
                .Include(x => x.Pictures)
                .SingleOrDefault(x => x.Name == pageName);

            var viewModel = new PageViewModel()
            {
                Name = page.Name
            };

            return View(viewModel);
        }
    }
}

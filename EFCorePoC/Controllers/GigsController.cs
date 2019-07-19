using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCorePoC.Models;
using EFCorePoC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EFCorePoC.Controllers
{
    public class GigsController : Controller
    {
        private InvoiceDbContext _context;

        public GigsController()
        {
               _context = new InvoiceDbContext(); 
        }
        public IActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                Genres = _context.Genres.ToList()

            };
            return View(viewModel);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCorePoC.Services;
using Microsoft.AspNetCore.Mvc;

namespace EFCorePoC.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly IInvoiceService _service;

        public InvoiceController(IInvoiceService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var test = _service.getText();
            return View();
        }

        public IActionResult AddNewInvoice()
        {
            return View();
        }
    }
}
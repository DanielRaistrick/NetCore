using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCorePoC.DTOs;
using EFCorePoC.Services;
using EFCorePoC.ViewModels;
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
            var viewModel = new AddNewInvoiceViewModel();
            viewModel.invoiceDTO = new InvoiceDTO();

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AddNewInvoice(AddNewInvoiceViewModel viewModel)
        {
            var info = viewModel;//add breakpoint here to see the values passed into info variable
            return View("Index");
        }
    }
}
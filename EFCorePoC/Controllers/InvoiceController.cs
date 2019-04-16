using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCorePoC.DTOs;
using EFCorePoC.Models;
using EFCorePoC.Repository;
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
            return View();
        }

        public IActionResult AddNewInvoice()
        {
            var viewModel = new AddNewInvoiceViewModel();
            viewModel.invoiceDTO = new InvoiceDTO();
            viewModel.customerList = _service.ReturnAllCustomers();

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AddNewInvoice(AddNewInvoiceViewModel viewModel)
        {
            _service.PostInvoiceDTO(viewModel.invoiceDTO);

            return View("Index");
        }

        public IActionResult DeleteInvoice()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteInvoice(DeleteInvoiceViewModel viewModel)
        {
            _service.DeleteInvoice(viewModel.idToDelete);
            return View();
        }
    }
}
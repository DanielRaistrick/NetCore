using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCorePoC.Services;
using EFCorePoC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using EFCorePoC.DTOs;

namespace EFCorePoC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddNewCustomer()
        {
            var viewModel = new AddNewCustomerModel();
            viewModel.customerDTO = new CustomerDTO();

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AddNewCustomer(AddNewCustomerModel viewModel)
        {
            _service.CreateCustomerDTO(viewModel.customerDTO);

            return View("Index");
        }

        public IActionResult DeleteCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteCustomer(DeleteCustomerViewModel viewModel)
        {
            _service.DeleteCustomer(viewModel.idToDelete);
            return View();
        }
    }
}
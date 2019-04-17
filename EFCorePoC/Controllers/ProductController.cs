using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EFCorePoC.Services;
using EFCorePoC.ViewModels;
using EFCorePoC.DTOs;

namespace EFCorePoC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddNewProduct()
        {            
            var viewModel = new AddNewProductViewModel();
            viewModel.productDTO = new ProductDTO();

            return View(viewModel);  
        }

        [HttpPost]
        public IActionResult AddNewProduct (AddNewProductViewModel viewModel)
        {            
            if (ModelState.IsValid)
            {
                _service.CreateProductDTO(viewModel.productDTO);
                return View("Index");
            }
            else
            {
                return Json(new { status = "error", message = "error creating product", commonSense = "add a product code" });
            }
        }

        public IActionResult DeleteProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteProduct (DeleteProductViewModel viewModel)
        {
            _service.DeleteProduct (viewModel.idToDelete);
            return View();
        }
    }
}
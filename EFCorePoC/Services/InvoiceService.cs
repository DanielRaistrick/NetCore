﻿using EFCorePoC.DTOs;
using EFCorePoC.Models.InvoiceDbModels;
using EFCorePoC.Repository;
using EFCorePoC.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePoC.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository _repository;
        private readonly ICustomerService _customerService;
        private readonly IProductService _productService;

        public InvoiceService(IInvoiceRepository repository, ICustomerService customerService, IProductService productService)
        {
            _repository = repository;
            _customerService = customerService;
            _productService = productService;
        }

        public void PostInvoiceDTO(InvoiceDTO dto)
        {
            _repository.PostInvoice(dto.ConvertDTOToInvoice(dto));
        }

        public void DeleteInvoice(int id)
        {
            _repository.DeleteInvoice(id);
        }

        public IEnumerable<SelectListItem> ReturnAllCustomers()
        {
            //note - this will ideally call Chris and Nigel's class in the future, but for now I'm just wiring this in so we can return the customers
            List<CustomerDTO> customerList = _customerService.ReturnAllCustomers();

            var result = customerList.Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.CustomerName.ToString()
            });

            return result;
        }

        public IEnumerable<SelectListItem> ReturnAllProducts()
        {
            //note - this will ideally call Chris and Nigel's class in the future, but for now I'm just wiring this in so we can return the customers
            List<ProductDTO> productList = _productService.ReturnAllProducts();
                        
            var result = productList.Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.ProductCode.ToString()                 
            });            

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCorePoC.DTOs;
using EFCorePoC.Models.APIModels;
using EFCorePoC.Repository;
using EFCorePoC.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCorePoC.Controllers
{
    [Route("api/[action]")]
    [ApiController]
    public class APIController : ControllerBase
    {
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly IProductRepository _productRepository;
        private readonly ICustomerService _customerService;
        private readonly IProductService _productService;

        public APIController(IInvoiceRepository invoiceRepository, ICustomerRepository customerRepository, IProductRepository productRepository, ICustomerService customerService, IProductService productService)
        {
            _invoiceRepository = invoiceRepository;
            _customerRepository = customerRepository;
            _productRepository = productRepository;
            _customerService = customerService;
            _productService = productService;
        }

        [HttpGet]
        [ActionName("invoices")]
        public IActionResult GetInvoices()
        {
            //Example URI https://localhost:44367/api/invoices
            try
            {
                var results = _invoiceRepository.ReturnAllInvoices();
                return Ok(results);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }
        [HttpGet]
        [ActionName("customers")]
        public IActionResult GetCustomers()
        {
            //Example URI https://localhost:44367/api/customers
            try
            {
                var results = _customerRepository.ReturnAllCustomers();
                return Ok(results);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }
        [HttpGet]
        [ActionName("products")]
        public IActionResult GetProducts()
        {
            //Example URI https://localhost:44367/api/customers
            try
            {
                var results = _productRepository.ReturnAllProducts();
                return Ok(results);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }

        [HttpGet("{id:int}")]
        [ActionName("invoices")]
        public IActionResult GetInvoice(int id)
        {
            //Example URI https://localhost:44367/api/invoices/2
            try
            {
                var results = _invoiceRepository.ReturnInvoice(id);
                if (results.Count() != 1)
                {
                    return this.StatusCode(StatusCodes.Status204NoContent, "Nothing Nada No Way");
                }
                return Ok(results);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }

        [HttpGet("{id:int}")]
        [ActionName("customers")]
        public IActionResult GetCustomer(int id)
        {
            //Example URI https://localhost:44367/api/customers/2
            try
            {
                var results = _customerRepository.ReturnCustomer(id);
                if (results.Count() != 1)
                {
                    return this.StatusCode(StatusCodes.Status204NoContent, "Nothing Nada No Way");
                }
                return Ok(results);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }

        [HttpGet("{id:int}")]
        [ActionName("products")]
        public IActionResult GetProduct(int id)
        {
            //Example URI https://localhost:44367/api/products/2
            try
            {
                var results = _productRepository.ReturnProduct(id);
                if (results.Count() != 1)
                {
                    return this.StatusCode(StatusCodes.Status204NoContent, "Nothing Nada No Way");
                }
                return Ok(results);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }


        [HttpPost("")]
        [ActionName("invoices")]
        public IActionResult PostInvoice(InvoiceAPIModel model)
        {
            //Example URI https://localhost:44367/api/invoices
            try
            {
                CustomerDTO customerDTO = _customerService.ReturnCustomerByIdOld(model.CustomerId);
                ProductDTO productDTO = _productService.ReturnProductById(model.ProductId);
                _invoiceRepository.PostInvoice(model.ConvertModelToInvoice(model, customerDTO, productDTO));
                //_repository.PostInvoice(model);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }

        [HttpPost("")]
        [ActionName("products")]
        public ActionResult PostProduct(ProductAPIModel model)
        {
            //Example URI https://localhost:44367/api/products
            try
            {
                _productRepository.CreateProduct(model.ConvertModelToProduct(model));
                return Ok(model);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }

        [HttpPost("")]
        [ActionName("customers")]
        public ActionResult PostCustomer(CustomerAPIModel model)
        {
            //Example URI https://localhost:44367/api/customers
            try
            {
                _customerRepository.CreateCustomer(model.ConvertModelToCustomer(model));
                return Ok(model);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }


        [HttpDelete("{id:int}")]
        [ActionName("invoices")]
        public IActionResult DeleteInvoices(int id)
        {
            //Example URI https://localhost:44367/api/invoice
            try
            {
                var results = _invoiceRepository.ReturnInvoice(id);
                if (results.Count() != 1)
                {
                    return this.StatusCode(StatusCodes.Status204NoContent, "Nothing Nada No Way");
                }
                _invoiceRepository.DeleteInvoice(id);
                return Ok();
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }

        [HttpDelete("{id:int}")]
        [ActionName("products")]
        public ActionResult DeleteProduct(int id)
        {
            //Example URI https://localhost:44367/api/ProductAPI
            try
            {
                var results = _productRepository.ReturnProduct(id);
                if (results.Count() != 1)
                {
                    return this.StatusCode(StatusCodes.Status204NoContent, "Nothing Nada No Way");
                }
                _productRepository.DeleteProduct(id);
                return Ok();
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }

        [HttpDelete("{id:int}")]
        [ActionName("customers")]
        public ActionResult DeleteCustomer(int id)
        {
            //Example URI https://localhost:44367/api/customers
            try
            {
                var results = _customerRepository.ReturnCustomer(id);
                if (results.Count() != 1)
                {
                    return this.StatusCode(StatusCodes.Status204NoContent, "Nothing Nada No Way");
                }
                _customerRepository.DeleteCustomer(id);
                return Ok();
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }

        [HttpPut("")]
        [ActionName("invoice")]
        public ActionResult PutInvoice(InvoiceAPIModel model)
        {
            //Example URI https://localhost:44367/api/invoice
            try
            {
                var results = _invoiceRepository.ReturnInvoice(model.Id);
                if (results.Count() != 1)
                {
                    return this.StatusCode(StatusCodes.Status204NoContent, "Nothing Nada No Way");
                }

                CustomerDTO customerDTO = _customerService.ReturnCustomerByIdOld(model.CustomerId);
                ProductDTO productDTO = _productService.ReturnProductById(model.ProductId);
                _invoiceRepository.UpdateInvoice(model.ConvertModelToInvoice(model, customerDTO, productDTO));
                return Ok(model);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }
        [HttpPut("")]
        [ActionName("product")]
        public ActionResult PutProduct(ProductAPIModel model)
        {
            //Example URI https://localhost:44367/api/Product
            try
            {
                var results = _productRepository.ReturnProduct(model.Id);
                if (results.Count() != 1)
                {
                    return this.StatusCode(StatusCodes.Status204NoContent, "Nothing Nada No Way");
                }
                _productRepository.UpdateProduct(model.ConvertModelToProduct(model));
                return Ok(model);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }

        [HttpPut("")]
        [ActionName("customer")]
        public ActionResult PutCustomer(CustomerAPIModel model)
        {
            //Example URI https://localhost:44367/api/customer
            try
            {
                var results = _customerRepository.ReturnCustomer(model.Id);
                if (results.Count() != 1)
                {
                    return this.StatusCode(StatusCodes.Status204NoContent, "Nothing Nada No Way");
                }
                _customerRepository.UpdateCustomer(model.ConvertModelToCustomer(model));
                return Ok(model);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }
    }
}
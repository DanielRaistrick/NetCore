using EFCorePoC.Models.InvoiceDbModels;
using EFCorePoC.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using EFCorePoC.Repository;
using EFCorePoC.Models;

namespace InvoiceTest.Specs.Helpers
{
    public class CreateMocks
    {
        
        public static InvoiceDTO BasicInvoice()
        {
            InvoiceDTO invoiceDto = new EFCorePoC.DTOs.InvoiceDTO();            

            invoiceDto.CustomerReference = "Customer Ref";

            invoiceDto.Quantity = 1;
            invoiceDto.ItemNet = 100;
            invoiceDto.TaxRate = 20;
            invoiceDto.InvoiceDate = DateTime.Today.Date;
            invoiceDto.InvoiceNumber = 123456;

            return invoiceDto;
        }

        public static Customer BasicCustomer()
        {
            InvoiceDbContext invoiceDbContext = new InvoiceDbContext();
            InvoiceRepository invoiceRepository = new InvoiceRepository(invoiceDbContext);
            CustomerRepository custRepo = new CustomerRepository(invoiceDbContext);
            Customer cust = new Customer();
            cust.CustomerName = "TESTBOB";
            custRepo.CreateCustomer(cust);
            return cust;
        }

        public static Product BasicProduct()
        {
            InvoiceDbContext invoiceDbContext = new InvoiceDbContext();
            InvoiceRepository invoiceRepository = new InvoiceRepository(invoiceDbContext);
            ProductRepository prodRepo = new ProductRepository(invoiceDbContext);
            Product prod = new Product();
            prod.Name = "PRODBOB";
            prodRepo.CreateProduct(prod);
            return prod;
        }
    }
}

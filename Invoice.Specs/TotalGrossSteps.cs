using EFCorePoC.DTOs;
using EFCorePoC.Models;
using EFCorePoC.Models.InvoiceDbModels;
using EFCorePoC.Repository;
using EFCorePoC.Services;
using InvoiceTest.Specs.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace InvoiceTest.Specs
{
    [Binding]
    public class TotalGrossStepsSteps
    {
        InvoiceDbContext invoiceDbContext = new InvoiceDbContext();

        InvoiceDTO invoiceDto = InvoiceTest.Specs.Helpers.CreateMocks.BasicInvoice();
        InvoiceTest.Specs.Helpers.CreateMocks creator = new CreateMocks();
        Customer cust = InvoiceTest.Specs.Helpers.CreateMocks.BasicCustomer();
        Product prod = InvoiceTest.Specs.Helpers.CreateMocks.BasicProduct();

        List<Invoice> beforeInvoiceList;
        List<Invoice> afterInvoiceList;

        //create customer up here somewhere to get the id to pass intot he mockInvoice Service below


        [Given(@"I have an invoice with a quantity of (.*)")]
        public void GivenIHaveAnInvoiceWithAQuantityOf(int p0)
        {
            invoiceDto.Quantity = 5;
        }
        
        [Given(@"item net of (.*)")]
        public void GivenItemNetOf(int p0)
        {
            invoiceDto.ItemNet = 100;
        }
        
        [Given(@"tax rate of (.*)")]
        public void GivenTaxRateOf(int p0)
        {
            invoiceDto.TaxRate = 25;
        }
        
        [When(@"The invoice is created")]
        public void WhenTheInvoiceIsCreated()
        {
            InvoiceRepository invoiceRepository = new InvoiceRepository(invoiceDbContext);
            CustomerRepository custRepo = new CustomerRepository(invoiceDbContext);
            ProductRepository prodRepo = new ProductRepository(invoiceDbContext);
            CustomerService customerService = new CustomerService(custRepo);
            IProductService productService = new ProductService(prodRepo);

            var mockInvoiceService = new InvoiceService(invoiceRepository, customerService, productService);

            beforeInvoiceList = invoiceRepository.ReturnAllInvoices();
            prod.Name = "TESTPRODBOB";

            mockInvoiceService.PostInvoiceDTO(invoiceDto, cust.Id, prod.Id );
        }
        
        [Then(@"the total gross should be (.*)")]
        public void ThenTheTotalGrossShouldBe(int p0)
        {

            //got to get the created invoice back from the db and check the total gross
            InvoiceRepository invoiceRepository = new InvoiceRepository(invoiceDbContext);
            afterInvoiceList = invoiceRepository.ReturnAllInvoices();
            int lastElement = afterInvoiceList.Count() - 1;
            Invoice lastInvoice = afterInvoiceList[lastElement];
            
            Assert.AreEqual(625,  lastInvoice.TotalGross);
            Assert.AreNotEqual(beforeInvoiceList.Count, afterInvoiceList.Count);
            
        }
    }
}

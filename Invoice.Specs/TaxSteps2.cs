using System;
using TechTalk.SpecFlow;
using EFCorePoC;
using EFCorePoC.DTOs;
using Moq;
using EFCorePoC.Services;
using EFCorePoC.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EFCorePoC.Models;

namespace InvoiceTest.Specs
{
    [Binding]
    public class TaxSteps2
    {
        InvoiceDTO invoiceDto = new EFCorePoC.DTOs.InvoiceDTO();
        [Given(@"I have set the quantity to be (.*)")]
        public void GivenIHaveSetTheQuantityToBe(decimal quantity)
        {
            invoiceDto.Quantity = 5;
        }
        
        [Given(@"I have set the item Net to be (.*)")]
        public void GivenIHaveSetTheItemNetToBe(decimal itemNet)
        {
            invoiceDto.ItemNet = 100;

        }

        [When(@"The total net is calculated")]
        public void WhenTheTotalNetIsCalculated()
        {
            //InvoiceDbContext invoiceDbContext = new InvoiceDbContext();
            //InvoiceRepository invoiceRepository = new InvoiceRepository(invoiceDbContext);
            //CustomerRepository custRepo = new CustomerRepository(invoiceDbContext);
            //ProductRepository prodRepo = new ProductRepository(invoiceDbContext);
            //CustomerService customerService = new CustomerService(custRepo);
            //IProductService productService = new ProductService(prodRepo);
            //var mockInvoiceService = new InvoiceService(invoiceRepository, customerService, productService);

            //mockInvoiceService.calculateTotalNet(invoiceDto);
            EFCorePoC.Helpers.TaxService.calculateTotalNet(invoiceDto);

            //EFCorePoC.Services.InvoiceService invoice = new EFCorePoC.Services.InvoiceService(mockInvoice, mockCustomer, mockProduct);
            //mockInvoiceService.Setup(x => x.calculateTotalNet(invoiceDto)).Returns(() => invoiceDto);


        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(decimal result)
        {
            Assert.AreEqual(500, invoiceDto.TotalNet);
        }
    }
}

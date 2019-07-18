using EFCorePoC.Repository;
using System;
using TechTalk.SpecFlow;
using EFCorePoC.DTOs;
using EFCorePoC.Models;
using EFCorePoC.Repository;
using EFCorePoC.Services;
using EFCorePoC.Models.InvoiceDbModels;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InvoiceTest.Specs
{
    [Binding]
    public class InvoiceSavedSteps
    {


        InvoiceDTO invoiceDto = new EFCorePoC.DTOs.InvoiceDTO();
        CustomerDTO customerDTO = new EFCorePoC.DTOs.CustomerDTO();
        ProductDTO productDTO = new EFCorePoC.DTOs.ProductDTO();
        Invoice inv = new Invoice();
        Customer cust = new Customer();
        Product prod = new Product();

        [Given(@"a user has entered invoice information")]
        public void GivenAUserHasEnteredInvoiceInformation()
        {

            cust.ContactFirstName = "Bob";
            cust.ContactLastName = "Fred";
            cust.CustomerName = "Customer Name";

            prod.Location = "location";
            prod.Name = "prodName";

            
            inv.Customer = cust;
            inv.InvoiceNumber = 999;
            inv.InvoiceDate = DateTime.Today.Date;
            inv.ItemNet = 300;
            inv.Quantity = 5;
            inv.TaxRate = 20;
            inv.Product = prod;

        }
        
        [When(@"the invoice is added")]
        public void WhenTheInvoiceIsAdded()
        {
            InvoiceDbContext invoiceDbContext = new InvoiceDbContext();
            InvoiceRepository invoiceRepository = new InvoiceRepository(invoiceDbContext);
            invoiceRepository.PostInvoice(inv);
        }
        
        [Then(@"invoice should be saved to the db")]
        public void ThenInvoiceShouldBeSavedToTheDb()
        {
            //InvoiceDbContext invoiceDbContext = new InvoiceDbContext();
            //InvoiceRepository invoiceRepository = new InvoiceRepository(invoiceDbContext);


            //IQueryable<Invoice> invoices = invoiceRepository.ReturnInvoice(inv.Id); //THIS IS ALL WRONG

            //REWRITE THIS WHOLE TEST AGAIN NOT BOTHERING WITH THE DTO AND FOLLOWING SIMILAR TO HERE
            //https://msdn.microsoft.com/en-us/magazine/dn296508.aspx

            Assert.IsNotNull(inv.Id > 0);

        }
    }
}

using EFCorePoC.DTOs;
using EFCorePoC.Models;
using EFCorePoC.Repository;
using EFCorePoC.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace InvoiceTest.Specs
{
    [Binding]
    public class TaxCalcSteps
    {
        InvoiceDTO invoiceDto = new EFCorePoC.DTOs.InvoiceDTO();

        [Given(@"I have set quantity to be (.*)")]
        public void GivenIHaveSetQuantityToBe(int p0)
        {
            invoiceDto.Quantity = 5;
        }
        
        [Given(@"I have set item net to be (.*)")]
        public void GivenIHaveSetItemNetToBe(int p0)
        {
            invoiceDto.Quantity = 5;
            invoiceDto.ItemNet = 100;
        }
        
        [Given(@"I have set the tax Rate to be (.*)")]
        public void GivenIHaveSetTheTaxRateToBe(int p0)
        {
            invoiceDto.TaxRate = 20;
        }

        [When(@"the tax is calculated")]
        public void WhenTheTaxIsCalculated()
        {
            
            EFCorePoC.Helpers.TaxService.calculateTax(invoiceDto);


        }

        [Then(@"the resulting tax should be (.*)")]
        public void ThenTheResultingTaxShouldBe(int p0)
        {
            Assert.AreEqual(100, invoiceDto.TotalTax);
        }
    }
}

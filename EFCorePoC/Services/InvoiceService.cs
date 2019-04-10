using EFCorePoC.DTOs;
using EFCorePoC.Models.InvoiceDbModels;
using EFCorePoC.Repository;
using EFCorePoC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePoC.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository _repository;

        public InvoiceService(IInvoiceRepository repository)
        {
            _repository = repository;
        }

        public string getText()
        {
            return _repository.getInfo();
        }

        public string LookAtInvoice(InvoiceDTO dto)
        {
            char[] cArray = dto.CompanyName.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }

            Invoice invoice = new Invoice();
            InvoiceDTO invoiceDTO = new InvoiceDTO();
            invoice = invoiceDTO.ConvertDTOToInvoice(dto);
            _repository.AcceptInvoice(invoice);
            //convert dto to invoice

            return reverse;
        }
    }
}

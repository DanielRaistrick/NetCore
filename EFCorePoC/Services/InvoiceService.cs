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

        public void PostInvoiceDTO(InvoiceDTO dto)
        {
            /* - not sure what this is for?
            char[] cArray = dto.CompanyName.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            */

            _repository.PostInvoice(dto.ConvertDTOToInvoice(dto));
        }

        public void DeleteInvoice(int id)
        {
            _repository.DeleteInvoice(id);
        }
    }
}

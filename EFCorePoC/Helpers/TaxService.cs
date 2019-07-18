using EFCorePoC.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePoC.Helpers
{
    public class TaxService
    {
        public static InvoiceDTO calculateTotalGross(InvoiceDTO dto)
        {
            dto.TotalGross = dto.TotalNet + dto.TotalTax;
            return dto;
        }

        public static InvoiceDTO calculateTax(InvoiceDTO dto)
        {
            if (dto.Quantity != 0)
            {
                decimal quantity = dto.Quantity;
                decimal taxCalc = dto.ItemNet * (dto.TaxRate / 100);
                dto.TotalTax = quantity * taxCalc;
            }
            else
            {
                dto.TotalTax = dto.TotalNet * (dto.TaxRate / 100);
            }

            return dto;
        }

        public static InvoiceDTO calculateTotalNet(InvoiceDTO dto)
        {
            dto.TotalNet = dto.ItemNet * dto.Quantity;
            return dto;
        }
    }

    
}

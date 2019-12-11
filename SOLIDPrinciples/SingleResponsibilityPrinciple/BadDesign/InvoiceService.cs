using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SingleResponsibilityPrinciple.BadDesign
{
    public class InvoiceService
    {
        private readonly IInvoiceRepository _repository;


        public InvoiceService(IInvoiceRepository repository)
        {
            _repository = repository;
        }


        public List<Invoice> GetAllInvoices()
        {
            return _repository.Invoices.ToList();
        }

        public Invoice GetInvoiceById(int invoiceId)
        {
            return _repository.Invoices.FirstOrDefault(q => q.Id == invoiceId);
        } 


        public void ExportToPDF(MemoryStream  file)
        {
           // Export Invoice to Pdf file
        } 

        public void ExportToExcel(MemoryStream  file)
        {
            // Export Invoice to Excel file
        }

    }
}

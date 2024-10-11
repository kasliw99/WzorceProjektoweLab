namespace CodeSmells
{
    internal class TemporaryField
    {
        public class InvoiceGenerator
        {
            public void GenerateInvoice()
            {
                //_invoiceNumber = 12345;
                // Przekształcone tymczasowe pole _invoiceNumber na lokalną zmienną
                int invoiceNumber = 12345;

                //_pdfWriter = new PdfWriter($"Invoice_{_invoiceNumber}.pdf");
                // Przekształcone tymczasowe pole _pdfWriter na lokalną zmienną
                PdfWriter pdfWriter = new PdfWriter($"Invoice_{invoiceNumber}.pdf");

                // Generowanie faktury
                pdfWriter.Write("Invoice Content");
                pdfWriter.Close();
            }

            public void OtherMethod()
            {
                // Metoda, która nie korzystała z tymczasowych pól
            }
        }
    }
}

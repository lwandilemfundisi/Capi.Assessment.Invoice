using Capi.Assessment.Invoice.Domain.InvoiceDomainModel.Events;
using XFrame.Aggregates;

namespace Capi.Assessment.Invoice.Domain.InvoiceDomainModel
{
    public class Invoice : AggregateRoot<Invoice, InvoiceId>
    {
        #region Constructors

        public Invoice()
            : base(null)
        {
        }

        public Invoice(InvoiceId id)
            : base(id)
        {
        }

        #endregion

        #region Properties

        public string Client { get; set; }
        public string Email { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public DateOnly IssuedDate { get; set; }
        public DateOnly DueDate { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public DateTimeOffset? PaidAt { get; set; }

        #endregion

        #region Methods

        public void CreateInvoice(
            string client, 
            string email, 
            decimal amount, 
            string currency, 
            DateOnly issuedDate, 
            DateOnly dueDate, 
            string status, 
            string description)
        {
            Client = client;
            Email = email;
            Amount = amount;
            Currency = currency;
            IssuedDate = issuedDate;
            DueDate = dueDate;
            Status = status;
            Description = description;

            Emit(new CreatedInvoiceEvent(
                client,
                email,
                amount,
                currency,
                issuedDate,
                dueDate,
                status,
                description));
        }

        #endregion
    }
}

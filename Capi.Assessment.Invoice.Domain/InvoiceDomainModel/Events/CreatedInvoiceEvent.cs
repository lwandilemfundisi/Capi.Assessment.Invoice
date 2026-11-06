using XFrame.Aggregates.Events.AggregateEvents;

namespace Capi.Assessment.Invoice.Domain.InvoiceDomainModel.Events
{
    public class CreatedInvoiceEvent : AggregateEvent<Invoice, InvoiceId>
    {
        #region Constructors

        public CreatedInvoiceEvent(
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
        }

        #endregion

        #region Properties

        public string Client { get; }
        public string Email { get; }
        public decimal Amount { get; }
        public string Currency { get; }
        public DateOnly IssuedDate { get; }
        public DateOnly DueDate { get; }
        public string Status { get; }
        public string Description { get; }
        public DateTimeOffset? PaidAt { get; }

        #endregion
    }
}

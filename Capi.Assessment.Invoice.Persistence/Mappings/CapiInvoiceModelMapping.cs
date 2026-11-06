using Capi.Assessment.Invoice.Domain.InvoiceDomainModel;
using Capi.Assessment.Invoice.Persistence.ValueObjectConverters;
using Microsoft.EntityFrameworkCore;
using XFrame.Aggregates.Events;

namespace Capi.Assessment.Invoice.Persistence.Mappings
{
    public static class CapiInvoiceModelMapping
    {
        public static ModelBuilder CapiInvoiceModelMap(this ModelBuilder modelBuilder)
        {
            modelBuilder
            .Entity<Domain.InvoiceDomainModel.Invoice>()
            .Property(o => o.Id)
            .HasConversion(new IdentityValueConverter<InvoiceId>());

            return modelBuilder;
        }
    }
}

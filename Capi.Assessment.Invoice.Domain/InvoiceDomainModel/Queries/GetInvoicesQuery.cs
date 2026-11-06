using XFrame.Aggregates.Queries;
using XFrame.Persistence;
using XFrame.Persistence.EFCore.Queries.CriteriaQueries;

namespace Capi.Assessment.Invoice.Domain.InvoiceDomainModel.Queries
{
    #region Query

    public class GetInvoicesQuery : EFCoreCriteriaDomainQuery<Invoice>, IQuery<IEnumerable<Invoice>>
    {
    }

    #endregion

    #region Query Handler

    public class GetInvoicesQueryHandler(IPersistenceFactory persistenceFactory) 
        : EFCoreCriteriaDomainQueryHandler<Invoice>(persistenceFactory), IQueryHandler<GetInvoicesQuery, IEnumerable<Invoice>>
    {

        #region IQuery Handler Members

        public Task<IEnumerable<Invoice>> ExecuteQueryAsync(
            GetInvoicesQuery query, 
            CancellationToken cancellationToken)
        {
            return FindAll(query);
        }

        #endregion
    }

    #endregion
}

using Capi.Assessment.Invoice.Api.Extensions;
using Capi.Assessment.Invoice.Api.Models.RequestModels;
using Capi.Assessment.Invoice.Api.Models.ResponseModels;
using Capi.Assessment.Invoice.Domain.InvoiceDomainModel;
using Capi.Assessment.Invoice.Domain.InvoiceDomainModel.Commands;
using Microsoft.AspNetCore.Mvc;
using XFrame.Aggregates.Commands;

namespace Capi.Assessment.Invoice.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController(ICommandBus commandBus) : ControllerBase
    {
        private readonly ICommandBus _commandBus = commandBus;

        [HttpPost]
        public async Task<CreateInvoiceResponseModel> CreateInvoice(CreateInvoiceRequestModel model)
        {
            var cmd = new CreateInvoiceCommand(
                InvoiceId.New,
                model.Client,
                model.Email,
                model.Amount,
                model.Currency,
                model.IssuedDate,
                model.DueDate,
                model.Status,
                model.Description);

            var createResult = await _commandBus.PublishAsync(cmd, CancellationToken.None);

            return new CreateInvoiceResponseModel 
            {
                IsSuccess = createResult.IsSuccess,
                Errors = createResult.GetErrors()
            };
        }
    }
}

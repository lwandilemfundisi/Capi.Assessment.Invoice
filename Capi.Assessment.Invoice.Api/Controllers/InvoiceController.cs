using Capi.Assessment.Invoice.Api.Models.RequestModels;
using Capi.Assessment.Invoice.Api.Models.ResponseModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Capi.Assessment.Invoice.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        [HttpPost]
        public async Task<CreateInvoiceResponseModel> CreateInvoice(CreateInvoiceRequestModel model)
        {
            return null;
        }
    }
}

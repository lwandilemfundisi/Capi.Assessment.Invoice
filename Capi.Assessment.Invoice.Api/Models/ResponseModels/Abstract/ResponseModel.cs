namespace Capi.Assessment.Invoice.Api.Models.ResponseModels.Abstract
{
    public abstract class ResponseModel
    {
        public bool IsSuccess { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}

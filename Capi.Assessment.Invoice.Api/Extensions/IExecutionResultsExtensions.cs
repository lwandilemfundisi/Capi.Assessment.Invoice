using XFrame.Aggregates.ExecutionResults;

namespace Capi.Assessment.Invoice.Api.Extensions
{
    public static class IExecutionResultsExtensions
    {
        public static IEnumerable<string> GetErrors(this IExecutionResult result)
        {
            if (result is FailedExecutionResult failedResult)
            {
                return failedResult.Errors.Select(e => e.Text);
            }
            return Enumerable.Empty<string>();
        }
    }
}

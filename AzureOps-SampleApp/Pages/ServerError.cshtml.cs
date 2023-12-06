using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AzureOps_SampleApp.Pages
{
    public class ServerError : PageModel
    {
        private readonly ILogger<ServerError> _logger;

        public ServerError(ILogger<ServerError> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogError("サーバーエラーを意図的に発生させます");
            // サーバーエラーを意図的に発生させます
            throw new Exception();

        }
    }
}

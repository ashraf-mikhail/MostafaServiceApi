using System.Web.Http;
using AzureApi.Services;

namespace AzureApi.Controllers
{
    [RoutePrefix("api")]
    public class ReadifyController : ApiController
    {
        private readonly IReadifyService _readifyService;

        public ReadifyController(IReadifyService service)
        {
            _readifyService = service;
        }

        public ReadifyController() : this(new ReadifyPuzzels()) { }

        [Route("Token")]
        [HttpGet]
        public string Token()
        {
            return _readifyService.GetToken();
        }

        [Route("Fibonacci")]
        [HttpGet]
        public long Fibonacci(int n)
        {
            return _readifyService.CalculateFibonacci(n);
        }

        [Route("ReverseWords")]
        [HttpGet]
        public string ReverseWords(string sentence)
        {
            return _readifyService.ReverseWords(sentence);
        }

        [Route("TriangleType")]
        [HttpGet]
        public string TriangleType(int a, int b, int c)
        {
            return _readifyService.GetTriangleType(a, b, c);
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace AzureApi.Controllers
{
  [RoutePrefix("api")]
  public class ReadifyController : ApiController
  {
    // GET api/<controller>
    public IEnumerable<string> Get()
    {
      return new string[] { "value1", "value2" };
    }

    [Route("Token")]
    [HttpGet]
    public string Token()
    {
      return Guid.NewGuid().ToString();
    }
    
    [Route("Fibonacci")]
    [HttpGet]
    public long Fibonacci(long n)
    {
      long result = 0;
      long v1, v2;
      v1 = 0;
      v2 = 1;

      if (n == 0)
        result = v1;
      else if (n == 1)
        result = v2;
      else if (n > 1)
      {
        for (int i = 2; i <= n; i++)
        {
          result = v1 + v2;
          v1 = v2;
          v2 = result;
        }
      }

      return result;
    }
    [Route("ReverseWords")]
    [HttpGet]
    public string ReverseWords(string input)
    {
            if (string.IsNullOrWhiteSpace(input)) // we can use string.IsNullOrEmpty
                return string.Empty;

            StringBuilder results = new StringBuilder(); // string builder for better performance
            Stack stack = new Stack();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    stack.Push(input[i]);
                }
                else
                {
                    while (stack.Count > 0)
                    {
                        results.Append(stack.Pop());
                    }
                    results.Append(' ');
                }
            }
            while (stack.Count > 0) // make this loop in case we have one word statment and for the last word in a statment
            {
                results.Append(stack.Pop());
            }

            return results.ToString();
        }

        [Route("TriangleType")]
        [HttpGet]
        public string TriangleType(int a, int b, int c)
    {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return "Error";
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                return "Error";
            }

            if (a == b && b == c)
                return "Equilateral";

            if (a == b || a == c || b == c)
                return "Isosceles";

            return "Scalene";
    }

    // DELETE api/<controller>/5
    public void Delete(int id)
    {
    }
  }
}
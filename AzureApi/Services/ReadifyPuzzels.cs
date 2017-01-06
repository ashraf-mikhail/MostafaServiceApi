using System.Collections;
using System.Net;
using System.Text;
using System.Web.Http;

namespace AzureApi.Services
{
    public class ReadifyPuzzels: IReadifyService
    {
        public string GetToken()
        {
           return "b3d3a0d2-e6a8-4976-be8b-356ba3fc0308";
        }

        public long CalculateFibonacci(int fibonacciIndex)
        {
            if (fibonacciIndex == 0)
            {
                return 0;
            }

            if (fibonacciIndex > 92 || fibonacciIndex < -92) // it will exceed the long MaxValue
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            bool isNegative = false;
            if (fibonacciIndex < 0)
            {
                fibonacciIndex = -1 * fibonacciIndex;
                isNegative = true;
            }

            long a = 0;
            long b = 1;
            for (int i = 31; i >= 0; i--)
            {
                long d = a * (b * 2 - a);
                long e = a * a + b * b;
                a = d;
                b = e;
                if ((((uint)fibonacciIndex >> i) & 1) != 0)
                {
                    long c = a + b;
                    a = b;
                    b = c;
                }
            }

            if (isNegative && fibonacciIndex % 2 == 0)
            {
                a = -1 * a;
            }
            return a;
        }

        public string ReverseWords(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
            {
                return string.Empty;
            }

            StringBuilder results = new StringBuilder();
            Stack stack = new Stack();

            foreach (char t in sentence)
            {
                if (t != ' ')
                {
                    stack.Push(t);
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
            while (stack.Count > 0)
            {
                results.Append(stack.Pop());
            }

            var result = results.ToString();

            return result;
        }

        public string GetTriangleType(int firstSide, int secondSide, int thirdSide)
        {
            const string error = "Error";
            const string equilateral = "Equilateral";
            const string isosceles = "Isosceles";
            const string scalene = "Scalene";

            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
            {
                return error;
            }

            if ((long)firstSide + (long)secondSide <= thirdSide || (long)firstSide + (long)thirdSide <= secondSide || (long)secondSide + (long)thirdSide <= firstSide) //cast to long in case of adding a,b or c are Max int
            {
                return error;
            }

            if (firstSide == secondSide && secondSide == thirdSide)
            {
                return equilateral;
            }

            if (firstSide == secondSide || firstSide == thirdSide || secondSide == thirdSide)
            {
                return isosceles;
            }

            return scalene;
        }
    }
}
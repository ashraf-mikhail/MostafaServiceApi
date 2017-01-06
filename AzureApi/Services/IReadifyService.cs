namespace AzureApi.Services
{
    public interface IReadifyService
    {
        string GetToken();
        long CalculateFibonacci(int fibonacciIndex);
        string ReverseWords(string sentence);
        string GetTriangleType(int firstSide, int secondSide, int thirdSide);

    }
}

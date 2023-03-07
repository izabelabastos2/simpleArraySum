using System.Linq;
using System;

class Result
{

    /*
     * Complete the 'simpleArraySum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY ar as parameter.
     */

    public static int simpleArraySum(List<int> ar)
    {
        int total = ar.Sum();
        Console.WriteLine(total);
        return total;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("digite o tamanho do vetor:");
        int lenght = Convert.ToInt32(Console.ReadLine().Trim());

        Console.WriteLine("digite o vetor:");

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.simpleArraySum(ar);


    }
}

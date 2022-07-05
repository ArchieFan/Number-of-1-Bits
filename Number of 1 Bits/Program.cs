public class Solution
{
    public int HammingWeight(uint n)
    {
        int res = 0;
        //string s = Convert.ToString(n, 2);
        while (n != 0)
        {
            if (n % 2 == 1)
                res++;
            n = n >> 1;
        }
        return res;
    }

    static void Main()
    {
        uint x = 11;
        string s = Convert.ToString(x, 2);
        Solution solution = new Solution();
        int res = solution.HammingWeight(x);
        Console.WriteLine(res);
    }
}
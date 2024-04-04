using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Security.Principal;
using System.Text;




public class Solution
{
    public int MinOperations(int[] nums)
    {
        Array.Sort(nums);

        return 0;
    }
    public int NumberOfBeams(string[] bank)
    {
        int result = 0;
        List<int> count = new List<int>();
        for (int i = 0; i < bank.Length; i++)
        {
            if (bank[i].Count(x => x == '1') != 0) count.Add(bank[i].Count(x => x == '1'));
        }
        for (int i = 0; i < count.Count - 1; i++)
        {
            result += count[i] * count[i + 1];
        }
        return result;
    }
    public IList<IList<int>> FindMatrix(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        int i = 0;
        int current = 0;
        Array.Sort(nums);
        while (i < nums.Length - 1)
        {
            result[current].Add(nums[i]);
            if (nums[i] == nums[i + 1])
            {
                current++;
                i++;
            }
            else
            {
                i++;
                current = 0;
            }
        }
        return result;
    }
    public int FindContentChildren(int[] g, int[] s)
    {
        Array.Sort(g);
        Array.Sort(s);
        int i = 0;
        int j = 0;
        for (; i < g.Length && j < s.Length;)
        {
            if (g[i] <= s[j])
            {
                i++;
                j++;
            }
            else j++;
        }
        return i;
    }
    /* public bool MakeEqual(string[] words)
     {
         List<char> list = new List<char>();
         foreach (string s in words)
         {
             foreach (char c in s)
             {
                 list.Add(c);
             }
         }
         int n = words.Length;
         List<char> charlist = list.Distinct().ToList();
         int np = charlist.Count;
         int[] p = new int[np]();

     }*/
    /*public int GetLengthOfOptimalCompression(string s, int k)
    {
        if (k == s.Length) return 0;
        //declare a linked list to store a char and its count
        LinkedList<KeyValuePair<char, int>> list = new LinkedList<KeyValuePair<char, int>>();

        //store value and count of each char in s

    }*/
    public int NumDecodings(string s)
    {
        while (s[0] == '0')
        {
            s.Remove(0);
        }
        return 0;
    }
    // Help me build a SHA-256 hash function
    public string Sha256(string randomString)
    {
        var crypt = new System.Security.Cryptography.SHA256Managed();
        var hash = new System.Text.StringBuilder();
        byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
        foreach (byte theByte in crypto)
        {
            hash.Append(theByte.ToString("x2"));
        }
        return hash.ToString();
    }
    public int minCost(String colors, int[] neededTime)
    {
        int result = 0;
        List<int> sub = new List<int>();
        int i = 0;
        for (; i < colors.Length; i++)
        {
            if (i == colors.Length - 1)
            {
                sub.Add(neededTime[i]);
                result += sub.Sum() - sub.Max();
                break;
            }
            if (colors[i] == colors[i + 1])
            {
                sub.Add(neededTime[i]);
            }
            else if (colors[i] != colors[i + 1])
            {
                sub.Add(neededTime[i]);
                result += sub.Sum() - sub.Max();
                sub.Clear();
            }
        }
        return result;
    }
    public int MaxWidthOfVerticalArea(int[][] points)
    {
        var index = 0;
        Array.Sort(points, (x, y) => x[index].CompareTo(y[index]));
        int result = points[1][0] - points[0][0];
        for (int i = 1; i < points.Length - 1; i++)
        {
            if (points[i + 1][0] - points[i][0] > result) result = points[i + 1][0] - points[i][0];
        }
        return result;
    }
    public int BuyChoco(int[] prices, int money)
    {
        int min1 = prices[0];
        int min2 = prices[1];
        if (min1 > min2)
        {
            int temp = min1;
            min1 = min2;
            min2 = temp;
        }
        for (int i = 2; i < prices.Length; i++)
        {
            if (prices[i] <= min1)
            {
                min2 = min1;
                min1 = prices[i];
            }
            if (prices[i] > min1 && prices[i] < min2) min2 = prices[i];
        }
        if (min1 + min2 <= money) { return money - min1 - min2; }
        else return money;
    }
    /*public int LengthOfLongestSubstring(string s)
    {
        List<KeyValuePair<char,int>> list = new List<KeyValuePair<char,int>>();
        List<char> list = s.Distinct().ToList();

        foreach(KeyValuePair<char,int> k in list)
        {
            total.ad
        }

    }*/

    public int MaxProductDifference(int[] nums)
    {
        int max1 = nums[0];
        int max2 = nums[1];
        if (max1 < max2)
        {
            int temp = max1;
            max1 = max2;
            max2 = temp;
        }
        for (int i = 2; i < nums.Length; i++)
        {
            if (nums[i] >= max1)
            {
                max2 = max1;
                max1 = nums[i];
            }
            if (nums[i] < max1 && nums[i] > max2)
            {
                max2 = nums[i];
            }
        }
        int min1 = nums[0];
        int min2 = nums[1];
        if (min1 > min2)
        {
            int temp = min1;
            min1 = min2;
            min2 = temp;
        }
        for (int i = 2; i < nums.Length; i++)
        {
            if (nums[i] <= min1)
            {
                min2 = min1;
                min1 = nums[i];
            }
            if (nums[i] > min1 && nums[i] < min2)
            {
                min2 = nums[i];
            }
        }
        return (max1 * max2) - (min1 * min2);
    }
    public bool isAnagram(String s, String t)
    {
        List<char> list = new List<char>();
        for (int i = 0; i < s.Length; i++)
        {
            list.Add(s[i]);
        }
        for (int j = 0; j < t.Length; j++)
        {
            if (list.Contains(t[j])) list.Remove(t[j]);
        }
        if (list.Count != 0 || s.Length < t.Length) return false; else return true;
    }
    public int NumSpecial(int[][] mat)
    {
        int cols = mat[0].Length;
        int rows = mat.Length;
        int count = 0;

        return count;
    }



    public int[][] OnesMinusZeros(int[][] grid)
    {
        int[] cols = new int[grid[0].Length];
        int[] rows = new int[grid.Length];
        int[][] result = new int[grid.Length][];
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] != 0) rows[i]++;
                else rows[i]--;
            }
        }
        for (int i = 0; i < cols.Length; i++)
        {
            for (int j = 0; j < rows.Length; j++)
            {
                if (grid[i][j] != 0) cols[i]++;
                else cols[i]--;
            }
        }
        for (int i = 0; i < rows.Length; i++)
        {
            for (int j = 0; j < cols.Length; j++)
            {
                result[i][j] = rows[i] - cols[j];
            }
        }
        return result;
    }
    public int FindSpecialInteger(int[] arr)
    {
        int i = 0;
        int n = arr.Length;
        int count = 1;
        while (i < n - 1 && count <= n / 4)
        {
            if (arr[i] == arr[i + 1]) count++;
            else count = 0;
            i++;
        }
        return arr[i];
    }
    public int[][] Transpose(int[][] matrix)
    {
        int n = matrix[0].Length;
        int[][] result = new int[n][];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = matrix.Select(x => x[i]).ToArray();
        }
        return result;
    }
    public string LargestOddNumber(string num)
    {
        char[] odd = { '1', '3', '5', '7', '9' };
        int i = num.Length - 1;
        while (i >= 0)
        {
            if (odd.Contains(num[i])) break;
            else i--;
        }
        if (i == -1) return string.Empty;
        else return num.Remove(++i);
    }
    public int AddTotalMoney(int start, int step)
    {
        return step * (start * 2 + step - 1) / 2;
    }

    public void BubbleSort(int[] num)
    {
        for (int i = 0; i < num.Length; i++)
        {
            for (int j = 0; j < num.Length - 1; j++)
            {
                if (num[j] >= num[j + 1])
                {
                    int temp = num[j];
                    num[j] = num[j + 1];
                    num[j + 1] = temp;
                }
            }
        }
    }
    public int MaxProduct(int[] nums)
    {
        int max1 = nums[0];
        int max2 = nums[1];
        if (max1 > max2)
        {
            int temp = max1; max1 = max2; max2 = temp;
        }
        for (int i = 2; i < nums.Length; i++)
        {
            if (nums[i] >= max2)
            {
                max1 = max2;
                max2 = nums[i];
            }
            if (nums[i] > max1 && nums[i] < max2)
            {
                max1 = nums[i];
            }
        }
        return (max1 - 1) * (max2 - 1);
    }
    public int TotalMoney(int n)
    {
        int m = n;
        int start = 1;
        int add = 0;
        while (m > 7)
        {
            add += AddTotalMoney(start, 7);
            start += 1;
            m -= 7;
        }
        if (m == 0) return add;
        else return add + AddTotalMoney(start, m);
    }
    public string LargestGoodInteger(string num)
    {
        char r = '/';
        for (int i = 1; i < num.Length; i++)
        {
            if (num[i] == num[i - 1] && num[i] == num[i + 1] && num[i] > r)
                r = (char)num[i];
        }
        if (r <= '9' && r >= '0')
            return (r.ToString() + r.ToString() + r.ToString());
        else return string.Empty;
    }
    public int coinPile(int[] piles)
    {
        int result = 0;
        int count = 0;
        int n = piles.Length - 1;
        Array.Sort(piles);
        for (; count < piles.Length / 3; count++)
        {
            result += piles[n - 1];
            n -= 2;
        }
        return result;
    }
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        StringBuilder w1 = new StringBuilder();
        StringBuilder w2 = new StringBuilder();
        for (int i = 0; i < word1.Length; i++)
        {
            w1.Append(word1[i]);
        }
        for (int i = 0; i < word2.Length; i++)
        {
            w2.Append(word2[i]);
        }
        return (w1.ToString().Equals(w2.ToString()));
    }
    public bool IsUgly(int n)
    {
        if (n <= 0) return false;
        else
        {
            while (n % 2 == 0)
            {
                n /= 2;
            }
            while (n % 3 == 0)
            {
                n /= 3;
            }
            while (n % 5 == 0)
            {
                n /= 5;
            }
            if (n == 1) return true; else return false;
        }
    }
    /*    public IList<IList<int>> Permute(int[] nums) 
            IList < IList<int> > result = new List<IList<int>>();

            return result;
        }*/

    public int LengthOfLongestSubstring(string s)
    {

        if (!string.IsNullOrEmpty(s))
        {
            int len;
            int max = 0;
            int left;
            int right;
            for (left = 0; left < s.Length; left++)
            {
                HashSet<char> chars = new HashSet<char>();
                for (right = left; right < s.Length; right++)
                {
                    len = right - left + 1;

                    if (chars.Contains(s[right]))
                    {
                        if (len >= max)
                        {
                            max = len;
                        }
                        break;
                    }
                    chars.Add(s[right]);
                }
            }
            return max;
        }
        else return 0;
    }
    public int[] PlusOne(int[] digits)
    {
        BigInteger middl = 0;
        string s = "";
        s = String.Join("", digits);
        BigInteger m = BigInteger.Parse(s);
        m = m + 1;
        char[] res = m.ToString().ToCharArray();
        return Array.ConvertAll(res, c => (int)Char.GetNumericValue(c));
    }

    public long ZeroFilledSubarray(int[] nums)
    {
        long result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            long count = 0;
            if (nums[i] == 0)
            {
                count = count + 1;
                Console.WriteLine("s{0}", count);
            }
            else
            {
                result += count * (count + 1) / 2;
                Console.WriteLine(count * (count + 1) / 2);
                count = 0;
            }
        }
        return result;
    }



    public IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> result = new List<IList<int>>();
        result[0] = new List<int>(1);
        for (int i = 1; i < numRows; i++)
        {
            result.Add(new List<int>(1));
        }
        for (int i = 1; i < numRows; i++)
        {
            for (int j = 1; j < i; j++)
            {
                result[i][j] = result[i - 1][j - 1] + result[i - 1][j];
            }
        }
        return result;
    }
    public int MinCostConnectPoints(int[][] points)
    {
        return -1;
    }
    public int[] SortArrayByParity(int[] nums)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 != 0) result.Add(nums[i]);
            else result.Insert(0, nums[i]);
        }
        return result.ToArray();
    }


    public int FindDuplicate(int[] nums)
    {
        int[] alt = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            alt[nums[i]] += 1;
        }
        int j = 1;
        while (alt[j] < 2)
        {
            j++;
        }
        return j;
    }

    public bool WinnerOfGame(string colors)
    {
        List<char> chars = new List<char>();
        chars.AddRange(colors);
        int point = 0;
        for (int i = 1; i < chars.Count - 1; i++)
        {
            if (chars[i] == 'A' && chars[i - 1] == 'A' && chars[i + 1] == 'A') point++;
            if (chars[i] == 'B' && chars[i - 1] == 'B' && chars[i + 1] == 'B') point--;
        }
        return point > 0;
    }

    public int[] ProductExceptSelf(int[] nums)
    {
        int[] result = new int[nums.Length];
        HashSet<int> set = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0) set.Add(i);
        }
        switch (set.Count)
        {
            case 0:
                int product = 1;
                for (int i = 0; i < nums.Length; i++)
                {
                    product *= nums[i];
                }
                for (int j = 0; j < result.Length; j++)
                {
                    result[j] = product / nums[j];
                }
                break;
            case 1:
                product = 1;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (set.Contains(i)) continue;
                    else product *= nums[i];
                }
                for (int i = 0; i < result.Length; i++)
                {
                    if (set.Contains(i)) result[i] = product;
                    else result[i] = 0;
                }
                break;
            default:
                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = 0;
                }
                break;

        }
        return result;
        //solved
    }
    public int SingleNumber(int[] nums)
    {
        int[] k = nums.Distinct().ToArray();
        return k[0];
        //int sum = 0;
        //for (int i = 0; i < nums.Length; i++)
        //{
        //    sum += nums[i];
        //}
        //if (sum % 2 == 0) sum++;
        //for(int i =0;i < nums.Length;i++)
        //{
        //    if ((sum - nums[i]) % 2 == 0)
        //        return i;
        //}
        //return -1;
        //unsolved
    }

    public int MaxDepth(string s)
    {
        int n = s.Length;
        int count = 0;
        int max = Int32.MinValue;
        for(int i =0;i < n;i++)
        {
            if (s[i] == '(') count++;
            if (s[i] == ')') count--;
            if(count > max) max = count;
        }
        return max;
    }

    public IList<string> LetterCombinations(string digits)
    {
        IList<string> result = new List<string>();
        List<(int, string)> keyboard = new List<(int, string)>
        {                                   (0,""),
                                            (1,""),
                                            (2, "abc"),
                                            (3, "def"),
                                            (4, "ghi"),
                                            (5, "jkl"),
                                            (6, "mno"),
                                            (7, "pqrs"),
                                            (8, "tuv"),
                                            (9, "wxyz")};
        //foreach(char _char in digits)
        //{
        //    for(int )
        //}
        return result;
    }
    public uint reverseBits(uint n)
    {
        uint res = 0;
        char[] binary = Convert.ToString(n, 2).Reverse().ToArray();
        for (int i = binary.Length - 1; i >= 0; i--)
        {
            res += (uint)Math.Pow(2, Convert.ToInt16(binary.Length - 1 - i));
        }
        return res;
    }
    public bool IsIsomorphic(string s, string t)
    {
        //List<(char, char)> mapp = new List<(char, char)>();
        List<char> chars = new List<char>();
        List<char> chars2 = new List<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (chars.Contains(s[i]) == false)
            {
                chars.Add(s[i]);
                if (chars2.Contains(t[i])) return false;

                chars2.Add(t[i]);
            }
            if (chars.Contains(s[i]))
            {
                int n = chars.IndexOf(s[i]);
                if (chars2[n] != t[i]) return false;
            }
        }
        return true;
    }
    //public bool IsHappy(int n)
    //{
    //    int sum = 0;
    //    do
    //    {
    //        sum
    //    }
    //    return false;

    //}
    public string CountAndSay(int n)
    {
        int r = n;
        string result = "";
        int[] count = new int[10];
        while (n > 0)
        {
            int temp = n % 10;
            count[temp]++;
            n /= 10;
        }
        Console.WriteLine("r=" + r);
        string order = r.ToString();
        char[] disc_order = order.Distinct().ToArray();
        foreach (int i in count)
        {
            Console.WriteLine(i);
        }
        foreach (char c in disc_order)
        {
            Console.WriteLine("{0}", c);

        }
        for (int i = 0; i < disc_order.Length; i++)
        {
            int k = (int)(disc_order[i] - '0');
            result += count[k].ToString();
            result += disc_order[i].ToString();


        }
        return result;
    }

    public int FindMinArrowShots(int[][] points)
    {
        int count = 1;
        Console.WriteLine(points.Length);
        Array.Sort(points, (int[] a, int[] b) => a[0] - b[0]);

        int[] current = points[0];
        //foreach (var ele in points)
        //{
        //    Console.WriteLine("{0}   {1}", ele[0], ele[1]);
        //}
        for (int i = 0; i < points.Length; i++)
        {
            Console.WriteLine("{0}      {1}", current[0], current[1]);
            if (current[1] < points[i][0])
            {
                count++;
                current = points[i];
                Console.WriteLine("{0}    {1}", current[0], current[1]);
            }
            else
            {
                if (points[i][1] < current[1]) current[1] = points[i][1];
                if (points[i][0] > current[0]) current[0] = points[i][0];
            }
        }
        return count;
        //solved
    }


    public IList<int> SpiralOrder(int[][] matrix)
    {
        IList<int> result = new List<int>();
        List<string> direct = new List<string> { "left", "right", "down", "up" };
        int m = matrix.Length;
        int n = matrix[0].Length;
        while (result.Count < m * n)
        {

        }
        return result;
    }
    //public IList<string> GenerateParenthesis(int n)
    //{
    //    Stack<char> chars = new Stack<char>(6);
    //    chars.Push('(');
    //    foreach(char c in chars)
    //    {
    //        Console.WriteLine(c.ToString());
    //    }
    //    return null;
    //}

    public int ArrangeCoins(int n)
    {
        int num = 1;
        int count = 0;
        while (n > 0)
        {
            n -= num;
            num++;
            count++;
            if (n < 0) count--;
        }
        return count;
    }
    //public string FrequencySort(string s)
    //{
    //    Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
    //    for (int i = 0; i < s.Length; i++)
    //    {
    //        if (alpha.ContainsKey() alpha.
    //    }
    //}

    //public bool ContainsNearbyDuplicate(int[] nums, int k)
    //{
    //    int[][] ints = new int[10][1];
    //    for (int i = 0; i < nums.Length; i++)
    //    {
    //        if (ints[nums[i]][0] == 0) ints[nums[i]][0]++;
    //        else
    //        {
    //            if (Math.Abs(ints[nums[i]][0] - i) <= k) return true;
    //            else ints[nums[i]][0] = i;
    //        }
    //    }
    //    return false;
    //}

    public int LeastInterval(char[] tasks, int n)
    {
        Dictionary<char, int> alphabet = new Dictionary<char, int>();
        foreach (char task in tasks)
        {
            if (alphabet.ContainsKey(task)) alphabet[task]++;
            else
            { alphabet[task] = 1; }
        }

        alphabet = alphabet.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        var k = alphabet.First();
        int count = 0;
        foreach (var element in alphabet)
        {
            if (element.Value == k.Value) count++;
        }
        return Math.Max((alphabet.First().Value - 1) * (n + 1) + count, tasks.Length);
    }
    public int TrailingZeroes(int n)
    {
        int count = 0;

        // Keep dividing n by powers of 5 and adding the result to the count
        while (n >= 5)
        {
            count += n / 5;
            n /= 5;
        }

        return count;
    }
    public bool MakeEqual(string[] words)
    {
        StringBuilder str = new StringBuilder();
        int count = words.Length;
        for (int i = 0; i < count; i++)
        {
            str.Append(words[i]);
        }
        Dictionary<char, int> dict = new Dictionary<char, int>();
        for (int i = 0; i < str.Length; i++)
        {
            if (dict.ContainsKey(str[i])) dict[str[i]]++;
            else dict[str[i]] = 1;
        }
        foreach (var e in dict.Keys)
        {
            if (e % count != 0) return false;
        }
        return true;
    }
    public int MinSubArrayLen(int target, int[] nums)
    {
        int sum = 0;
        for (int t = 0; t < nums.Length; t++)
        {
            if (nums[t] >= target) return 1;
            sum += nums[t];
        }
        if (target > sum) return 0;
        int min = Int32.MaxValue;
        sum = 0;
        int start = 0;
        int i = 0;
        while (start < nums.Length)
        {
            sum += nums[i];
            if (sum >= target && i - start < min)
            {
                min = i - start;
                start++;
                sum -= nums[start];
            }
            else i++;
        }
        return min;
    }
    public bool CheckPossibility(int[] nums)
    {
        int temp = nums[0];
        int credit = 1;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] > nums[i + 1])
            {
                if (credit == 0) return false;
                else
                {
                    credit = 0;
                    nums[i + 1] = nums[i];
                    continue;
                }
            }
        }
        return true;
    }
    public IList<int> FindDuplicates(int[] nums)
    {
        int i = 0;
        while (i < nums.Length)
        {
            int corr = nums[i] - 1;
            if (nums[i] <= nums.Length && nums[i] != nums[corr])
            {
                int temp = nums[i];
                nums[i] = nums[corr];
                nums[corr] = temp;
            }
            else
            {
                i++;
            }
        }
        for (int j = 0; j < nums.Length; j++)
        {
            Console.Write(nums[j] + "\t");
        }
        IList<int> list = new List<int>();
        i = 0;
        bool okay = true;
        while (i < nums.Length - 1)
        {
            if (nums[i] != nums[i + 1])
            {
                if (okay == true)
                {
                    list.Add(nums[i]);
                    i++;
                }
                else
                {

                    okay = true;
                    i++;
                }

            }
            else
            {
                if (nums[i] == nums[i + 1]) okay = false;
                i++;
            }
        }
        Console.WriteLine();
        foreach (int k in list)
        {
            Console.Write(k + "\t");
        }
        return list;
    }
    public int FirstMissingPositive(int[] nums)
    {
        int[] ints = new int[nums.Length + 1];
        int result = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > nums.Length || nums[i] < 1)
                continue;
            else
                ints[nums[i]] = 1;
        }
        for (int i = 1; i < ints.Length; i++)
        {
            if (ints[i] == 0)
            {
                result = i;
                break;
            }
            else
                result++;
        }
        return result;

    }
    public int FindNonMinOrMax(int[] nums)
    {
        int min = int.MaxValue;
        int max = 0;
        int i = 0;
        for (i = 0; i < nums.Length; i++)
        {
            if (nums[i] > max) max = nums[i];
            if (nums[i] < min) min = nums[i];
        }
        i = 0;
        while (i < nums.Length)
        {
            if (nums[i] < max && nums[i] > min)
            {
                return nums[i];
            }
            else
            {
                i++;
            }
        }
        return -1;
    }

    public int? MaximumJumps(int[] nums, int target)
    {
        int jump = 0;
        int left = 0;
        int right = nums.Length - 1;
        return null;
    }

    //public IList<string> GenerateParenthesis(int n)
    //{
    //    IList<string> result = new List<string>();
    //    int closeNeed = 0;
    //    int pairLeft = n;
    //    Stack<char> chars = new Stack<char>();
    //    while(pairLeft != 0)
    //    {

    //    }
    //}
    public bool CheckRecord(string s)
    {
        return (s.Count(e => e=='A') < 2 && !s.Contains("LLL")) ;
        
    }
    public static void Main()
    {
        //drive code for ugly 1
        /*        int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(s.IsUgly(m));*/

        //drive code for SortArrayByParity
        /*Console.Write("Array size:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        for(int i=0;i<n;i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        int[] array2 = solution.SortArrayByParity(array);
        for(int i=0;i<n;i++)
        {
            Console.WriteLine(array2[i]);
        }
    }*/
        /*int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine(  solution.SingleNumber(array));*/
        /*int[] arr = new int[] { 2, 4, 1, 2, 7, 8 };*/
        //int[] test = { 10, 2, 5, 2, 3, 4, 3, 4, 7, 2 };

        Solution solution = new Solution();
        /*int k = solution.NumberOfBeams(new string [] { "00000100000000100000001000010000000000000000000000000001010000000000010000000101011000010001000010001000000001000000010110000100000001000100000000000000000001000000000000000000000000000000010000000000000010000000110000001000000000001000000000000000011011110000000000000000010000000000001000000000001000000000000000100000000100000100000000000000000001000000000000000001000000000000000000001001001010000000010000000100000000000000000000000101010000011001000000000000000000010100000001000101100001100111" });
        Console.WriteLine( k );*/
        // int k = solution.PlusOne(Convert.ToInt32(Console.ReadLine()));
        //int k = solution.LengthOfLongestSubstring("nz");
        //Console.WriteLine("result" + k);
        //int[] k = { 0, 9, 8, 9, 0 };
        //int result = solution.SingleNumber(k);
        //k = k.Distinct().ToArray();
        //foreach (int i in k) { Console.WriteLine(i); }
        int[] test = { 2, 1, 5, 6, 2, 3 };
        Console.WriteLine();

    }
}
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.CompilerServices;

public class Kata
{
    //Highest Scoring Word https://www.codewars.com/kata/57eb8fcdf670e99d9b000272
    public static string High(string s)
    {
        List<string> words = s.Split(' ').ToList();
        int maxScore = 0;
        int maxScoreIndex = 0;

        foreach (string word in words)
        {
            int wordScore = getWordScore(word);
            if (wordScore > maxScore)
            {
                maxScoreIndex = words.IndexOf(word);
                maxScore = wordScore;
            }
        }

        return words[maxScoreIndex];
    }

    public static int getWordScore(string s)
    {
        int score = 0;

        foreach (char c in s)
            score += c - 96;

        return score;
    }
    //
    //Split String https://www.codewars.com/kata/515de9ae9dcfc28eb6000001
    public static string[] SplitString(string str)
    {
        List<string> res = new List<string>();

        if (str.Length % 2 != 0)
            str += '_';

        for (int i = 0; i < str.Length; i += 2)
		{
            res.Add(new string(new char[]{
                str[i], 
                str[i + 1]
            }));
		}

        return res.ToArray();
    }
	//
	//Array.diff https://www.codewars.com/kata/523f5d21c841566fde000009
	public static int[] ArrayDiff(int[] a, int[] b)
	{
        List<int> res = a.ToList();
        foreach (int num in b)
            if (res.Contains(num))
                while(!res.Contains(num))
                    res.Remove(num);
        return res.ToArray();
	}
	//
	//Human Readable Time https://www.codewars.com/kata/52685f7382004e774f0001f7
	public static string GetReadableTime(int seconds)
	{
		return string.Format("{0:00}:{1:00}:{2:00}", seconds / 3600, (seconds / 60) % 60, seconds % 60);
	}
	//
	//Sum of Digits / Digital Root https://www.codewars.com/kata/541c8630095125aba6000c00
	public static int DigitalRoot(long n)
	{
        string str = n.ToString();
        int subtotal;
        do
        {
            subtotal = 0;
            foreach (char c in str)
                subtotal += c - 48;
            str = subtotal.ToString();
        } while (subtotal > 10);

        return subtotal;
	}
	//
	//Build Tower https://www.codewars.com/kata/576757b1df89ecf5bd00073b
	public static string[] TowerBuilder(int nFloors)
    {
        List<string> res = new List<string>();
        for (int i = 0; i < nFloors; i++)
        {
            string padding = new string(' ', nFloors - i - 1);
            res.Add(padding + new string('*', 1 + i * 2) + padding);
		}
		return res.ToArray();
	}
	//
	//Where my anagrams at? https://www.codewars.com/kata/523a86aa4230ebb5420001e1
	public static List<string> Anagrams(string anagram, List<string> words)
	{
        anagram = SortString(anagram);

		List<string> res = new List<string>();

        foreach (string word in words)
            if (SortString(word) == anagram)
                res.Add(word);

        return res;
    }

    public static string SortString(string str)
    {
		char[] characters = str.ToArray();
		Array.Sort(characters);
        return new string(characters);
	}
	//
	//Is a number prime? https://www.codewars.com/kata/5262119038c0985a5b00029f
	public static bool IsPrime(int n)
	{
		if (n == 2 || n == 3)
			return true;
		if (n % 2 == 0 || n <= 1 || n % 3 == 0)
			return false;

        for (int i = 3; i <= Math.Sqrt(n); i += 2)
            if (n % i == 0)
                return false;

		return true;
	}
    //
    //Josephus Permutation https://www.codewars.com/kata/5550d638a99ddb113e0000a2
    public static List<object> JosephusPermutation(List<object> items, int k)
    {
        List<object> res = new List<object>();

        for (int i = k; items.Count != 0; i += k)
        {
            while (i > items.Count)
                i -= items.Count;
            res.Add(items[i - 1]);
            items.RemoveAt(i - 1);
            i--;
        }
        return res;
    }
    //
}

public class Programm
{
    static void Main()
    {

	}
}
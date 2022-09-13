using System.Collections.Generic;
using System.Linq;

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
	// Human Readable Time https://www.codewars.com/kata/52685f7382004e774f0001f7
	public static string GetReadableTime(int seconds)
	{
		return string.Format("{0:00}:{1:00}:{2:00}", seconds / 3600, (seconds / 60) % 60, seconds % 60);
	}
}

public class Programm
{
    static void Main()
    {
		Kata.GetReadableTime(0);
		Kata.GetReadableTime(5);
		Kata.GetReadableTime(86399);
	}
}
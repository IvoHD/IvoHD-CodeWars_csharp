﻿using System.Collections.Generic;
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
    // Split String https://www.codewars.com/kata/515de9ae9dcfc28eb6000001
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
}

public class Programm
{
    static void Main()
    {

    }


}
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
}

public class Programm
{
    static void Main()
    {
        Console.WriteLine(Kata.High("aaa b"));
    }


}
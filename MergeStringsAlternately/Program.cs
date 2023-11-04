using System.Net.Http.Headers;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Solution.MergeAlternately("abcd","pq"));
    }

}

public static class Solution {
    public static string MergeAlternately(string word1, string word2) 
    {
            var result = "";
            result += word1[1];


        var word1Queue = new Queue<char>();
        var word2Queue = new Queue<char>();
        string mixedWords = "";

        foreach(char c in word1)
        {
            word1Queue.Enqueue(c);
        }
        
        foreach(char c in word2)
        {
            word2Queue.Enqueue(c);
        }

        for (int i = 0; i < word1.Length + word2.Length; i++)
        {
            if (i == 0 || i % 2 == 0 && word1Queue.Count != 0)
            {
                mixedWords += word1Queue.Dequeue();
            }
            else if (word2Queue.Count != 0)
            {
                mixedWords += word2Queue.Dequeue();
            }
            else break;
        }

        if (word1Queue.Count == 0) 
        {
            while (word2Queue.Count > 0)
            {
            mixedWords += word2Queue.Dequeue();
            }
        }
        else
        {
            while (word1Queue.Count > 0)
            {
            mixedWords += word1Queue.Dequeue();
            }
        }

        return mixedWords;
    }
}
using System;

/* Using names.txt (right click and 'Save Link/Target As...'), 
a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order.
Then working out the alphabetical value for each name,
multiply this value by its alphabetical position in the list to obtain a name score.

For example, when the list is sorted into alphabetical order,
COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list.
So, COLIN would obtain a score of 938 × 53 = 49714.

What is the total of all the name scores in the file? */

namespace ProjectEuler
{
    public class Problem22
    {
        string text = System.IO.File.ReadAllText(@"/Users/widewoods/Documents/GitHub/Project-Euler/ProjectEuler/ProjectEuler/p022_names.txt");

        public void Solve()
        {
            string[] names = text.Split(",");

            for(int i = 0; i < names.Length; i++)
            {
                names[i] = names[i].Replace("\"", "");
            }

            Array.Sort(names);

            long sumOfNameScores = 0;

            foreach(string name in names)
            {
                char[] chars = name.ToCharArray();

                int sumOfAlphabeticalValue = 0;
                foreach(char c in chars)
                {
                    sumOfAlphabeticalValue += char.ToUpper(c) - 64;
                }

                int nameScore = sumOfAlphabeticalValue * (Array.IndexOf(names, name) + 1);

                sumOfNameScores+= nameScore;
            }

            Console.WriteLine(sumOfNameScores);
        }
    }
}

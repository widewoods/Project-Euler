using System;
using System.Collections.Generic;

//Problem: https://projecteuler.net/problem=59

namespace ProjectEuler
{
    public class Problem59
    {
        public void Solve(string text)
        {
            string[] substring = text.Split(" ");

            int[] key = new int[3];

            char[] message = new char[substring.Length];

            for(int i = 0; i < 26; i++)
            {
                key[0] = i + 97;
                for (int j = 0; j < 26; j++)
                {
                    key[1] = j + 97;
                    for (int k = 0; k < 26; k++)
                    {
                        key[2] = k + 97;

                        message = Decrypt(substring, key);

                        Dictionary<char, int> charCount = Analysis(message);

                        bool candidate = true;
                        for(int a = 0; a <= 31; a++)
                        {
                            if (charCount.ContainsKey((char)a))
                            {
                                candidate = false;
                            }
                        }
                        for (int a = 123; a < 256; a++)
                        {
                            if (charCount.ContainsKey((char)a))
                            {
                                candidate = false;
                            }
                        }

                        if (candidate)
                        {
                            foreach(char c in message)
                            {
                                Console.Write(c);
                            }
                            string info = String.Format("The Key was {0}, {1}, {2}", key[0], key[1], key[2]);
                            Console.WriteLine("\n" + info + "\n");
                        }
                    }
                }
            }

            //Code to find sum *after* I had found the key
            //Key:e, x, p
            int sum = 0;
            foreach (char c in Decrypt(substring, new int[3] { 101, 120, 112 }))
            {
                sum += c;
            }
            Console.WriteLine("\n" + sum);
        }

        char[] Decrypt(string[] message, int[] key)
        {
            int n = 0;

            char[] decryptedMsg = new char[message.Length];

            foreach (string str in message)
            {
                int asciiValue = int.Parse(str);

                int decrypted = 0;

                switch (n % 3)
                {
                    case 0:
                        decrypted = asciiValue ^ key[0];
                        break;
                    case 1:
                        decrypted = asciiValue ^ key[1];
                        break;
                    case 2:
                        decrypted = asciiValue ^ key[2];
                        break;
                }

                char c = Convert.ToChar(decrypted);

                decryptedMsg[n] = c;

                n++;
            }

            return decryptedMsg;
        }

        //Returns most frequent chars in message
        Dictionary<char, int> Analysis(char[] message)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach(char c in message)
            {
                if (!charCount.ContainsKey(c))
                {
                    charCount.Add(c, 1);
                }
                else
                {
                    charCount[c] = charCount[c] + 1;
                }
            }

            int largestValue = 0;
            char mostFrequent = 'e';
            foreach(KeyValuePair<char, int> keyValuePair in charCount)
            {
                if(keyValuePair.Value > largestValue)
                {
                    largestValue = keyValuePair.Value;
                    mostFrequent = keyValuePair.Key;
                }
            }

            return charCount;
        }
    }
}

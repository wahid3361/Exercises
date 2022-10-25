using System;


namespace ExercisesClassLibrary
{
    public static class ReverseString
    {
        public static string ReverseStr(string word)
        {
            string reversedWord = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i];
            }

            return reversedWord;
        }
    }
}

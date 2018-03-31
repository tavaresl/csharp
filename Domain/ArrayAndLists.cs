using System;

namespace CSharpCases.Domain
{
    public class ArrayAndLists
    {
        public static string Reverse(string text)
        {
            var textLength = text.Length;
            var chars = new char[textLength];

            for (var i = textLength; i > 0; i--)
                chars[textLength- i] = text[i - 1];

            return new string(chars);
        }

        public static string[] GetLowestValues(string[] values, int count = 3)
        {
            var copiedValues = new string[values.Length];
            var sortedValues = new string[count];

            Array.Copy(values, copiedValues, values.Length);
            Array.Sort(copiedValues);

            for (var i = 0; i < count; i++)
                sortedValues[i] = copiedValues[i];

            return sortedValues;
        }
    }
}

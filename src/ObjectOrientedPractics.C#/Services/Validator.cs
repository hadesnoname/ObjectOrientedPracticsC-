using System;

namespace ObjectOrientedPractics.Services
{
    public static class ValueValidator
    {
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length > maxLength)
            {
                throw new ArgumentException($"{propertyName} должен быть меньше {maxLength} символов.");
            }
        }
    }
}


using System;
using System.Linq;

namespace ExceptionHandling
{
    public static class ThrowingExceptions
    {
        public static void CheckParameterAndThrowException(object obj)
        {
            if (obj is null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
        }

        public static void CheckBothParametersAndThrowException(object obj1, object obj2)
        {
            if (obj1 is null || obj2 is null)
            {
                throw new ArgumentNullException(obj1 is null ? nameof(obj1) : nameof(obj2));
            }
        }

        public static string CheckStringAndThrowException(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str;
        }

        public static string CheckBothStringsAndThrowException(string str1, string str2)
        {
            if (str1 is null || str2 is null)
            {
                throw new ArgumentNullException(str1 is null ? nameof(str1) : nameof(str2));
            }

            return string.Concat(str1, str2);
        }

        public static int CheckEvenNumberAndThrowException(int evenNumber)
        {
            if (evenNumber % 2 != 0)
            {
                throw new ArgumentException($"{nameof(evenNumber)} is not even!");
            }

            return evenNumber;
        }

        public static int CheckCandidateAgeAndThrowException(int candidateAge, bool isCandidateWoman)
        {
            if (!isCandidateWoman && (candidateAge < 16 || candidateAge > 63))
            {
                throw new ArgumentOutOfRangeException(nameof(candidateAge));
            }

            if (isCandidateWoman && (candidateAge < 16 || candidateAge > 58))
            {
                throw new ArgumentOutOfRangeException(nameof(candidateAge));
            }

            return candidateAge;
        }

        public static string GenerateUserCode(int day, int month, string username)
        {
            if (day > 31 || day < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(day));
            }

            if (month > 12 || month < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(month));
            }

            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException(nameof(username));
            }

            return $"{username}-{day}{month}";
        }
    }
}

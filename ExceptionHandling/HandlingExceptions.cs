using System;

namespace ExceptionHandling
{
    public static class HandlingExceptions
    {
        public static bool CatchException(object obj)
        {
            try
            {
                ThrowException(obj);
                return false;
            }
            catch (Exception)
            {
                return true;
            }
        }

        public static bool CatchArgumentNullException(object obj, out string exceptionMessage)
        {
            exceptionMessage = string.Empty;

            try
            {
                ThrowException(obj);
                return false;
            }
            catch (ArgumentNullException ex)
            {
                exceptionMessage = ex.Message;
                return true;
            }
        }

        public static bool CatchArgumentException(int i, out string exceptionMessage)
        {
            exceptionMessage = string.Empty;

            try
            {
                ThrowException(new object(), i);
                return false;
            }
            catch (ArgumentException ex)
            {
                exceptionMessage = ex.Message;
                return true;
            }
        }

        public static bool CatchArgumentOutOfRangeException(int j, out string exceptionMessage)
        {
            exceptionMessage = string.Empty;

            try
            {
                ThrowException(new object(), 1, j);
                return false;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                exceptionMessage = ex.Message;
                return true;
            }
        }

        public static bool CatchExceptions(object obj, int i, int j, bool throwException, out string exceptionMessage)
        {
            exceptionMessage = string.Empty;

            try
            {
                ThrowException(obj, i, j, throwException);
                return false;
            }
            catch (ArgumentNullException ex)
            {
                exceptionMessage = ex.Message;
                return true;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                exceptionMessage = ex.Message;
                return true;
            }
            catch (ArgumentException ex)
            {
                exceptionMessage = ex.Message;
                return true;
            }
            catch (Exception ex)
            {
                exceptionMessage = ex.Message;
                return true;
            }
        }

        private static void ThrowException(object obj, int i = 1, int j = 1, bool throwException = false)
        {
            if (obj is null)
            {
                throw new ArgumentNullException(nameof(obj), "obj is null.");
            }

            if (i == 0)
            {
                throw new ArgumentException("i parameter is invalid.", nameof(i));
            }

            if (j < 0 || j > 10)
            {
                throw new ArgumentOutOfRangeException(nameof(j), "j is out of range.");
            }

            if (throwException)
            {
#pragma warning disable CA2201 // Do not raise reserved exception types
                throw new Exception("exception is thrown.");
#pragma warning restore CA2201 // Do not raise reserved exception types
            }
        }
    }
}

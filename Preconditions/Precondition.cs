using System;

namespace ReneWiersma.Preconditions
{
    public static class Precondition
    {
        public static void Requires(bool precondition, string message = "Precondition failed") => 
            Requires(precondition, () => new ArgumentException(message));

        public static void Requires<TException>(bool precondition, Func<TException> func) where TException : Exception
        {
            if (!precondition)
                throw func.Invoke();
        }
    }
}

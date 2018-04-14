using System;

namespace SILT
{
    public class ApplicationException : Exception
    {
        #region Constructors
        public ApplicationException()
        {

        }

        public ApplicationException(string message) : base(message)
        {

        }

        public ApplicationException(string message, Exception inner) : base(message, inner)
        {

        }
        #endregion
    }
}

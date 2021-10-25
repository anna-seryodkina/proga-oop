using System;

namespace lab1
{
    class LineNotExistException : Exception
    {
        public string Line { get; }

        public LineNotExistException(){}

        public LineNotExistException(string message) : base(message){}

        public LineNotExistException(string message, Exception innerException) : base(message, innerException){}

        public LineNotExistException(string message, string st) : this(message)
        {
            Line = st;
        }
    }

}

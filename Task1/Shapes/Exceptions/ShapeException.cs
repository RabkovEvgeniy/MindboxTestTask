using System.Runtime.Serialization;

namespace Shapes.Exceptions
{

    [Serializable]
    public class ShapeException : Exception
    {
        public ShapeException() { }
        public ShapeException(string message) : base(message) { }
        public ShapeException(string message, Exception inner) : base(message, inner) { }
        protected ShapeException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}

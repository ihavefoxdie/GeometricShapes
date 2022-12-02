using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes.Classes
{
    [Serializable]
    public class TriangleException : GeometryException
    {
        public TriangleException()
        {
        }

        public TriangleException(string message) : base(message)
        {
        }

        public TriangleException(string message, Exception inner) : base(message, inner)
        {
        }

        public TriangleException(string message, int[] array) : base(message, array)
        {
            
        }

        public TriangleException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public TriangleException(string message, int[] array, Exception inner) : base(message, array, inner)
        {
        }
    }

    [Serializable]
    public class QuadrangleException : GeometryException
    {
        public QuadrangleException()
        {
        }

        public QuadrangleException(string message) : base(message)
        {
        }

        public QuadrangleException(string message, Exception inner) : base(message, inner)
        {
        }

        public QuadrangleException(string message, int[] array) : base(message, array)
        {
        }

        public QuadrangleException(string message, int[] array, Exception inner) : base(message, array, inner)
        {
        }

        protected QuadrangleException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    public class CircleException : GeometryException
    {
        public CircleException()
        {
        }

        public CircleException(string message) : base(message)
        {
        }

        public CircleException(string message, Exception inner) : base(message, inner)
        {
        }

        public CircleException(string message, int[] array) : base(message, array)
        {
        }

        public CircleException(string message, int[] array, Exception inner) : base(message, array, inner)
        {
        }

        protected CircleException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

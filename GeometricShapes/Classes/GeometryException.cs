using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes.Classes
{
    [Serializable]
    public class GeometryException : Exception
    {
        public Int32[]? Parameters
        {
            get;
            private set;
        }
        public GeometryException() : base()
        {

        }

        public GeometryException(string message) : base(message)
        {

        }

        public GeometryException(string message, Int32[] parameters) : base(message)
        {
            Parameters = parameters;
        }

        public GeometryException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}

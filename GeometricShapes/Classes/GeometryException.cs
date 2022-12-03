using System.Runtime.Serialization;

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

        public GeometryException(string message, Exception inner) : base(message, inner)
        {

        }

        public GeometryException(string message, Int32[] array) : base(message)
        {
            Parameters = array;
        }

        public GeometryException(string message, Int32[] array, Exception inner) : base(message, inner)
        {
            Parameters = array;
        }

        protected GeometryException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

            //Parameters = new Int32[info.];

            /*for (int i = 0; i < info.MemberCount; i++)
                Parameters[i] = info.GetInt32(i.ToString());*/
            Parameters = new Int32[info.GetInt32("Parameters Size")];
            for (int i = 0; i < Parameters.Length; i++)
            {
                Parameters[i] = info.GetInt32("Parameter " + i.ToString());
            }

        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
            {
                throw new ArgumentNullException();
            }

            if (Parameters is not null)
            {
                for (int i = 0; i < Parameters!.Length; i++)
                    info.AddValue("Parameter " + i.ToString(), Parameters[i]);
                info.AddValue("Parameters Size", Parameters!.Length);
            }
            base.GetObjectData(info, context);
        }
    }
}

using GeometricShapes.Classes;
using Shapes;
using System.Runtime.Serialization.Formatters.Binary;

namespace Testing
{
    static class Program
    {
        static void Main()
        {
            try
            {
                Triangle triangle = new(7, 100, 7);
            }
            catch (TriangleException e)
            {
                /*using (Stream stream = new MemoryStream())
                {
                    BinaryFormatter formatter = new();
                    formatter.Serialize(stream, e);
                    stream.Position = 0;
                    e = (TriangleException)formatter.Deserialize(stream);

                }*/
                
            }
        }
    }
}
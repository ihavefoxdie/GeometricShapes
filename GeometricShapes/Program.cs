using GeometricShapes.Classes;
using Shapes;
using System.IO;

namespace Testing
{


    static class Program
    {
        static void ActualPrint(GeometryException e, StreamWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            w.WriteLine("  :{0}", e.Message);
            for (int i = 0; i < e.Parameters?.Length; i++)
            {
                w.WriteLine(e.Parameters[i]);
            }

            w.WriteLine("-------------------------------\n");
            w.Close();
        }
        static void Print(GeometryException e)
        {
            DirectoryInfo _ = Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Logs");
            StreamWriter w = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Logs\\logAll.txt");
            ActualPrint(e, w);
        }

        static void PrintCircle(GeometryException e)
        {
            DirectoryInfo _ = Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Logs");
            StreamWriter w = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Logs\\logCircle.txt");
            ActualPrint(e, w);
        }
        static void Main()
        {
            Random rand = new();

            
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    Triangle triangle = new(rand.Next(100), rand.Next(100), rand.Next(100));
                }
                catch (TriangleException ex)
                {
                    Print(ex);
                }

                try
                {
                    Quadrangle quadrangle = new(rand.Next(100), rand.Next(100), rand.Next(100), rand.Next(100));
                }
                catch (QuadrangleException ex)
                {
                    Print(ex);
                }

                try
                {
                    Circle circle = new(rand.Next(-50, 100));
                }
                catch (CircleException ex)
                {
                    Print(ex);
                    PrintCircle(ex);
                }
            }


        }
    }
}
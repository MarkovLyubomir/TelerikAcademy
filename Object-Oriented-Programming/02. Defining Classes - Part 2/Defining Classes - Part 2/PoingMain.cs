namespace Point3D
{
    using System;

    public class PointMain
    {
        static void Main()
        {
            Point3D firstPoint = new Point3D(1.9, 2.3, 5.5);
            Point3D secondPoint = new Point3D(2.2, 1.7, 4.6);

            Console.WriteLine(firstPoint.ToString());
            Console.WriteLine(Point3D.O);

            double discance = CalculateDistance.Cauculate(firstPoint, secondPoint);
            Console.WriteLine(discance);

            Path route = new Path();

            route.Add(firstPoint);
            route.Add(secondPoint);
            route.Add(firstPoint);

            //PathStorage.SavePath("test.txt", route);

            Path loadedPath = PathStorage.LoadPath("test.txt");
            Console.WriteLine(loadedPath);
        }
    }
}

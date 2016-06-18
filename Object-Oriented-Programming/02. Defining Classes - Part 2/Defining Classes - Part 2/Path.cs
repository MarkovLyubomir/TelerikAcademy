namespace Point3D
{
    using System.Collections.Generic;

    class Path
    {
        private List<Point3D> points = new List<Point3D>();

        public Path()
        {

        }
        
        public Path Add(Point3D point)
        {
            this.points.Add(point);
            return this;
        }

        public override string ToString()
        {
            return string.Join(",\r\n", this.points.ToArray());
        }
    }
}

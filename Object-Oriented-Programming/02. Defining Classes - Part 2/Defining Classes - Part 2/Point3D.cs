namespace Point3D
{
    struct Point3D
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }

        private static readonly Point3D o = new Point3D();
         
        public static Point3D O
        {
            get { return o; }
        }

        public Point3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        
        //public static Point3D Parse(string p)

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", this.X, this.Y, this.Z);
        }

        
    }
}
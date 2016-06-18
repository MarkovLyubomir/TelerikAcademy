namespace Point3D
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.RegularExpressions;

    static class PathStorage
    {
        public static void SavePath(string filePath, Path path)
        {
            File.WriteAllText(filePath, path.ToString());
        }

        public static Path LoadPath(string filePath)
        {
            string[] pathStr = File.ReadAllLines(filePath);
            Path loadedPath = new Path();
           
            foreach (var line in pathStr)
            {
                MatchCollection matches = Regex.Matches(line, @"(\d+\.\d)+");

                List<double> pointArr = new List<double>();
                foreach (Match match in matches)
                {
                    pointArr.Add(Convert.ToDouble(match.Value));
                }

                loadedPath.Add(new Point3D(pointArr[0], pointArr[1], pointArr[2]));
            }

            return loadedPath;
        }
        
    }
}

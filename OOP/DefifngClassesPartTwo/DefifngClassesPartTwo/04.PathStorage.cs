using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartTwo
{
    static class PathStorage
    {
        private static readonly string fileName = "pathOfPoints.txt";
        public static void Save(Path pathOfPoints)
        {
            try
            {
                StreamWriter saver = new StreamWriter(fileName);
                using (saver)
                {
                    foreach (var point in pathOfPoints.Sequence)
                    {
                        saver.WriteLine(point.ToString());
                    }
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Invalid File destination");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File Not Found");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static Path Load()
        {
            StreamReader loader = new StreamReader(fileName);
            Path newPath = new Path();
            try
            {
                using (loader)
                {
                    string line = loader.ReadLine();
                    string[] pointData = line.Split(new char[] { '(', ')', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    string pointName = pointData[0];
                    int cX, cY, cZ;
                    cX = int.Parse(pointData[1]);
                    cY = int.Parse(pointData[2]);
                    cZ = int.Parse(pointData[3]);
                    Point3D point = new Point3D(pointName, cX, cY, cZ);
                    newPath.AddPoint(point);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }


            return newPath;
        }
    }
}

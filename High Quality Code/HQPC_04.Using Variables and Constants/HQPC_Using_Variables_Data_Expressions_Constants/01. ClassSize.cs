namespace HQPC_Using_Variables_Data_Expressions_Constants
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// Holds the size of a figure by its width and height
    /// </summary>
    public class Size
    {
        private double width;
        private double height;

        public Size(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public static Size GetRotatedSize(Size figure, double rotationAngle)
        {
            double newWidth = (Math.Abs(Math.Cos(rotationAngle)) * figure.width) +
                              (Math.Abs(Math.Sin(rotationAngle)) * figure.height);

            double newHeight = (Math.Abs(Math.Sin(rotationAngle)) * figure.width) +
                               (Math.Abs(Math.Cos(rotationAngle)) * figure.height);

            return new Size(newWidth, newHeight);
        }
    }
}
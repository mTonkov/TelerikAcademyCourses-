namespace HQPC_Using_Variables_Data_Expressions_Constants
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class Task_02_PrintStatistics
    {
        public void PrintStatistics(double[] arrayOfElements, int numberOfElements)
        {
            double maximumElement = this.GetMaximalElement(arrayOfElements, numberOfElements);
            Console.WriteLine(maximumElement);

            double minimumElement = this.GetMinimalElement(arrayOfElements, numberOfElements);
            Console.WriteLine(minimumElement);

            double averageElement = this.GetAverageElement(arrayOfElements, numberOfElements);
            Console.WriteLine(averageElement);
        }

        public double GetMaximalElement(double[] array, int numberOfElements)
        {
            double maximalElement = double.MinValue;

            for (int i = 0; i < numberOfElements; i++)
            {
                if (array[i] > maximalElement)
                {
                    maximalElement = array[i];
                }
            }

            return maximalElement;
        }

        public double GetMinimalElement(double[] array, int numberOfElements)
        {
            double minimalElement = double.MaxValue;

            for (int i = 0; i < numberOfElements; i++)
            {
                if (array[i] < minimalElement)
                {
                    minimalElement = array[i];
                }
            }

            return minimalElement;
        }

        public double GetAverageElement(double[] array, int numberOfElements)
        {
            double sum = 0;

            for (int i = 0; i < numberOfElements; i++)
            {
                sum += array[i];
            }

            double average = sum / numberOfElements;
            return average;
        }
    }
}
namespace Methods
{
    using System;

    public class Methods
    {
        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        public static string DigitToString(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentException("Invalid number!");
            }
        }

        public static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("There is nothing to search in");
            }

            int maxElement = int.MinValue;
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] > maxElement)
                {
                    maxElement = elements[i];
                }
            }

            return maxElement;
        }

        public static string FormatNumber(object number, string format)
        {
            string result = string.Empty;
            if (format == "f")
            {
                result = string.Format("{0:f2}", number);
            }
            else if (format == "%")
            {
                result = string.Format("{0:p0}", number);
            }
            else if (format == "r")
            {
                result = string.Format("{0,8}", number);
            }

            if (string.IsNullOrEmpty(result))
            {
                throw new ArgumentException("Invalid formatting");
            }

            return result;
        }

        public static bool IsHorizontal(double y1, double y2)
        {
            if (y1 == y2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsVertical(double x1, double x2)
        {
            if (x1 == x2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        public static void Main()
        {
            double triangleArea = CalcTriangleArea(3, 4, 5);
            Console.WriteLine(triangleArea);

            string digitAsString = DigitToString(5);
            Console.WriteLine(digitAsString);

            int maxNumber = FindMax(5, -1, 3, 2, 14, 2, 3);
            Console.WriteLine(maxNumber);

            string firstNumber = FormatNumber(1.3, "f");
            Console.WriteLine(firstNumber);
            string secondNumber = FormatNumber(0.75, "%");
            Console.WriteLine(secondNumber);
            string thirdNumber = FormatNumber(2.30, "r");
            Console.WriteLine(thirdNumber);

            double distance = CalcDistance(3, -1, 3, 2.5);
            Console.WriteLine(distance);
            bool horizontal = IsHorizontal(-1, 2.5);
            Console.WriteLine("Horizontal? " + horizontal);
            bool vertical = IsVertical(3, 3);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";
            string petersBirthdayAsString = peter.OtherInfo.Substring(peter.OtherInfo.Length - 10);
            peter.DateOfBirth = DateTime.Parse(petersBirthdayAsString);

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";
            string stellasBirthdayAsString = stella.OtherInfo.Substring(stella.OtherInfo.Length - 10);
            stella.DateOfBirth = DateTime.Parse(petersBirthdayAsString);

            bool isOlder = peter.IsOlderThan(stella);
            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, isOlder);
        }
    }
}

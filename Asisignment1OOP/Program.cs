namespace Asisignment1OOP
{
    internal class Program
    {
        static void Main(string[] args)
        #region q1
        {
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
            #endregion

        #region q2
        Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
        string input = Console.ReadLine();

        if (Enum.TryParse(input, true, out Season season))
            {
                switch (season)
                {
                    case Season.Spring:
                        Console.WriteLine("Spring: March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("Summer: June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Autumn: September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("Winter: December to February");
                        break;
                    default:
                        Console.WriteLine("Invalid season.");
                        break;
                }
            }
        else
            {
                Console.WriteLine("Invalid input. Please enter a valid season name.");
            }
            #endregion
            Console.WriteLine("***************************************");
        #region q3
            Permissions myPermissions = Permissions.Read | Permissions.Write;

            Console.WriteLine($"Current permissions: {myPermissions}");

            myPermissions |= Permissions.Execute;
            Console.WriteLine($"After adding Execute permission: {myPermissions}");

            myPermissions &= ~Permissions.Write;
            Console.WriteLine($"After removing Write permission: {myPermissions}");

            bool hasReadPermission = myPermissions.HasFlag(Permissions.Read);
            Console.WriteLine($"Has Read permission: {hasReadPermission}");
            #endregion
            Console.WriteLine("***************************************");
        #region q4
            Console.WriteLine("Enter a color name (Red, Green, Blue):");
            string input2 = Console.ReadLine();

            // Parse the input to the Colors enum
            if (Enum.TryParse(input2, true, out Colors color))
            {
                // Check if the color is a primary color
                if (IsPrimaryColor(color))
                {
                    Console.WriteLine($"{input2} is a primary color.");
                }
                else
                {
                    Console.WriteLine($"{input2} is not a primary color.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid color name.");
            }
            #endregion
            Console.WriteLine("***************************************");
        #region q5
            Console.WriteLine("Enter coordinates for Point 1 (X Y):");
            string[] point1Coords = Console.ReadLine().Split(' ');
            double point1X = Convert.ToDouble(point1Coords[0]);
            double point1Y = Convert.ToDouble(point1Coords[1]);

            Console.WriteLine("Enter coordinates for Point 2 (X Y):");
            string[] point2Coords = Console.ReadLine().Split(' ');
            double point2X = Convert.ToDouble(point2Coords[0]);
            double point2Y = Convert.ToDouble(point2Coords[1]);

            Point point1 = new Point(point1X, point1Y);
            Point point2 = new Point(point2X, point2Y);

            double distance = point1.DistanceTo(point2);

            Console.WriteLine($"Distance between Point 1 and Point 2: {distance}"); 
        #endregion
        }

        // Method to check if a color is a primary color =>q4
        private static bool IsPrimaryColor(Colors color)
        {
            switch (color)
            {
                case Colors.Red:
                case Colors.Green:
                case Colors.Blue:
                    return true;
                default:
                    return false;
            }
        }
    }
}

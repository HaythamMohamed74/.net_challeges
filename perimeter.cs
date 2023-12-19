class PerimeterRectangle
        {
            public void CalculateRectanglePerimeter()
            {
                Console.WriteLine("Please enter length!");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter width!");
                double width = Convert.ToDouble(Console.ReadLine());
                double perimeterRectangle = 2 * (length + width);
                Console.WriteLine($"Perimeter of the rectangle is: {perimeterRectangle}");
            }

             public void CalculateCirclePerimeter()
            {
            
            Console.WriteLine("Please enter radius!");
            double radius = Convert.ToDouble(Console.ReadLine());
            double per = 2 * 3.14 * radius;
            Console.WriteLine($"Perimeter of the circle is: {per}");
            }
        }
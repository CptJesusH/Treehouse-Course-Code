using System; // Needed to use Math. methods.

namespace TreehouseDefense {
    class Point {
        public readonly int X; // Attribute, Property, Cannot be written to from outside of the class. Must call Point method to write to it.
        public readonly int Y; // Attribute, Property, Cannot be written to from outside of the class. Must call Point method to write to it. 

        public Point(int x, int y) // Allows other parts of the program to assign a value to X and Y for use later in this classes methods. 
        {
            X = x; // Take values passed through by method calls and assigns external x value to internal X value. 
            Y = y; // Take values passed through by method calls and assigns external y value to internal Y value. 
        }

        public int DistanceTo(int x, int y) // Method for calculating dist btwn two points on grid using Cartesian Distance Formula
                                            // Takes external values (enemy location vs tower location) and calculates the distance between the two.
        {
            return (int)Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2)); // Return int value of the sqrt of X-x sqrd plus Y-y sqrd
        }

        public int DistanceTo(Point point) //Overloaded Method. Same name as other method, but takes different arguements. 
        {
            return DistanceTo(point.X, point.Y);
        }
    }
}

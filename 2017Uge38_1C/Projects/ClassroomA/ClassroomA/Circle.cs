using System;

namespace ClassroomA
{
    /// <summary>
    /// This class represents a geometric circle in a coordinate system.
    /// A cirlce has an x-coordinate, y-coordinate and a radius.
    /// </summary>
    public class Circle
    {
        #region Instance fields
        private double _x;
        private double _y;
        private double _radius;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a circle with no values available.
        /// Circle will be located at (x,y) = (0,0), and radius = 1.
        /// </summary>
        public Circle()
        {
            _x = 0;
            _y = 0;
            _radius = 1;
        }

        /// <summary>
        /// Create a circle with all values available.
        /// </summary>
        /// <param name="x">x-coordinate of circle</param>
        /// <param name="y">y-coordinate of circle</param>
        /// <param name="radius">radius of circle</param>
        public Circle(double x, double y, double radius)
        {
            _x = x;
            _y = y;
            _radius = radius;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Returns/sets the x-coordinate of the circle
        /// </summary>
        public double X
        {
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// Returns/sets the y-coordinate of the circle
        /// </summary>
        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }

        /// <summary>
        /// Returns/sets the radius of the circle
        /// </summary>
        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        /// <summary>
        /// Returns the area of the circle
        /// </summary>
        public double Area
        {
            get { return _radius * _radius * Math.PI; }
        }

        #endregion

        #region Methods
        /// <summary>
        /// Move the circle in the coordinate system
        /// </summary>
        /// <param name="xDistance">Distance to move in x-direction</param>
        /// <param name="yDistance">Distance to move in y-direction</param>
        public void Move(double xDistance, double yDistance)
        {
            _x = _x + xDistance;
            _y = _y + yDistance;
        }

        /// <summary>
        /// Enlarge the circle
        /// </summary>
        /// <param name="extraRadius">
        /// Amount by which to increase the radius. 
        /// Must be a positive number.
        /// </param>
        public void Enlarge(double extraRadius)
        {
            _radius = _radius + extraRadius;
        }

        /// <summary>
        /// Print information about the circle on the screen.
        /// </summary>
        public void PrintInformation()
        {
            Console.WriteLine($"Circle at ({X},{Y}), radius {Radius} (Area {Area:F})");
        }
        #endregion
    }
}
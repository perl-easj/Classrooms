namespace ClassroomA
{
    public class Circle
    {
        private double _x;
        private double _y;
        private double _r;

        public Circle(double x, double y, double r)
        {
            _x = x;
            _y = y;
            _r = r;
        }

        public double X
        {
            get { return _x; }
        }

        public double Y
        {
            get { return _y; }
        }

        public double Radius
        {
            get { return _r; }
        }
    }
}
using System;

namespace ClassroomA
{
    // 1) Er altid PUBLIC
    // 2) Navngives med STORT bogstav først
    // 3) En klasse pr. fil (f.eks.: klassen Car bor i filen "Car.cs")

    /// <summary>
    /// This class represents a geometric circle in a coordinate system.
    /// A circle has an x-coordinate, y-coordinate and a radius.
    /// </summary>
    public class Circle
    {
        #region Instance fields (objektets HUKOMMELSE)

        // 1) Er altid PRIVATE
        // 2) Navngives med _ (underscore) først, derefter navnet
        // 3) Hvert objekt har sit eget sæt af instance fields

        private double _x;
        private double _y;
        private double _radius;

        #endregion

        #region Constructor (sørger for, at et NYT objekt er i en sund tilstand FRA START)

        // 1) Hedder det samme som klassen
        // 2) Er altid PUBLIC
        // 3) Har ikke nogen returværdi (heller ikke void)
        // 4) Udføres når et nyt objekt skabes
        // 5) Man kan godt definere flere constructorer

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

        #region Properties (kan spørge på (og måske ændre) objektets TILSTAND)

        // 1) Er altid PUBLIC
        // 2) Navngives med STORT bogstav først
        // 3) Hvis vi gerne vil kunne SPØRGE PÅ værdien af en property:
        //    Definér GET-delen (er altid defineret)
        // 4) Hvis vi gerne vil kunne ÆNDRE værdien af en property:
        //    Definér SET-delen (kun defineret hvis behov)
        // 5) Ofte - men ikke altid - er en property knyttet direkte
        //    til et "bagvedliggende" instance field
        // 6) Andre properties kan være "beregnede" - ingen simpel
        //    sammenhæng med instance fields. Disse har som regel
        //    kun GET-delen defineret

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

        #region Methods (kan aktivere objektets OPFØRSEL)

        // 1) Er som regel PUBLIC, men i større klasser kan det give
        //    god mening også at have PRIVATE metoder
        // 2) Skal altid rumme
        //    a) ACCESS MODIFIER: PUBLIC eller PRIVATE
        //    b) TYPE for retur-værdi (evt. void hvis ingen retur-værdi)
        //    c) Metoden NAVN. Navngives med STORT bogstav først
        //    d) START-PARENTES (
        //    e) Hvis metoden benytter PARAMETRE, angives disse med TYPE og NAVN
        //       Hvis der er flere parametre, adskilles disse med KOMMA ,
        //    f) SLUT-PARENTES )
        //    g) Metoden KROP. Skrives mellem { og }. Hvis metoden skal returnere
        //       en værdi, skal der være en RETURN-statement i kroppen.

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
using System;

namespace ClassroomB
{
    public class Warrior
    {
        #region Instance fields
        private string _name;
        private int _hitPoints;

        private static Random _generator = new Random();
        #endregion

        #region Constructor
        public Warrior(string name, int hitPoints)
        {
            _name = name;
            _hitPoints = hitPoints;
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
        }

        public int HitPoints
        {
            get { return _hitPoints; }
        }

        public bool Dead
        {
            get { return _hitPoints <= 0; }
        }
        #endregion

        #region Methods
        public void ReceiveDamage(int damagePoints)
        {
            _hitPoints = _hitPoints - damagePoints;
        }

        public int DealDamage()
        {
            return _generator.Next(21) + 10;
        }
        #endregion
    }
}
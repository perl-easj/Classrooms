// ReSharper disable NotAccessedField.Local

using System;
using System.Collections.Generic;

namespace ClassroomB
{
    public class Army
    {
        private string _armyName;
        private Warrior _warriorA;
        private Warrior _warriorB;
        private Warrior _warriorC;

        public Army(string armyName, Warrior a, Warrior b, Warrior c)
        {
            _armyName = armyName;
            _warriorA = a;
            _warriorB = b;
            _warriorC = c;
        }

        public string ArmyName
        {
            get { return _armyName; }
        }

        public int DealDamage()
        {

            return _warriorA.DealDamage() + 
                   _warriorB.DealDamage() + 
                   _warriorC.DealDamage();
        }

        public void ReceiveDamage(int damagePoints)
        {
            int individualDamage = damagePoints / 3;
            _warriorA.ReceiveDamage(individualDamage);
            _warriorB.ReceiveDamage(individualDamage);
            _warriorC.ReceiveDamage(individualDamage);
        }

        public bool Dead
        {
            get { return _warriorA.Dead && _warriorB.Dead && _warriorC.Dead; }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{ArmyName} is dead: {Dead}");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"{_warriorA.Name} has {_warriorA.HitPoints} hit points");
            Console.WriteLine($"{_warriorB.Name} has {_warriorB.HitPoints} hit points");
            Console.WriteLine($"{_warriorC.Name} has {_warriorC.HitPoints} hit points");
        }
    }
}
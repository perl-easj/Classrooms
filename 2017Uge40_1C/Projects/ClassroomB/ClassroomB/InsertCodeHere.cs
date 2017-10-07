// ReSharper disable UnusedVariable
namespace ClassroomB
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            Warrior a1 = new Warrior("A", 100);
            Warrior a2 = new Warrior("B", 100);
            Warrior a3 = new Warrior("C", 100);

            Warrior b1 = new Warrior("X", 100);
            Warrior b2 = new Warrior("Y", 100);
            Warrior b3 = new Warrior("Z", 100);

            Army armyA = new Army("Norse Guardians", a1, a2, a3);
            Army armyB = new Army("Midland Marauders", b1, b2, b3);

            Battle battleManager = new Battle(armyA, armyB);
            battleManager.DoBattle();
        }
    }
}
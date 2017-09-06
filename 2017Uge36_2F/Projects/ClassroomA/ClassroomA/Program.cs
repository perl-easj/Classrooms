using System;
using System.Collections.Generic;

namespace ClassroomA
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Objects (Dog, Cat and Circle)
            Dog selfDog = new Dog("King", 35, "Labrador");
            Dog momDog = new Dog("Spot", 32, "Labrador");
            Dog dadDog = new Dog("Rufus", 38, "Labrador");

            Cat selfCat = new Cat("Stripes", 6);
            Cat momCat = new Cat("Duchess", 5);
            Cat dadCat = new Cat("Tom", 8);

            Circle selfCircle = new Circle(1, 1, 10);
            Circle momCircle = new Circle(2, 4, 20);
            Circle dadCircle = new Circle(3, 2, 15);
            #endregion


            #region FamilyRelation
            FamilyRelation<Dog> dogRelations = new FamilyRelation<Dog>(selfDog, dadDog, momDog);
            FamilyRelation<Cat> catRelations = new FamilyRelation<Cat>(selfCat, dadCat, momCat);
            // FamilyRelation<Circle> circleRelations = new FamilyRelation<Circle>(selfCircle, dadCircle, momCircle);
            // FamilyRelation<int> intRelations = new FamilyRelation<int>(4, 2, 42);
            #endregion


            #region Sorting
            List<Animal> animals = new List<Animal>();
            animals.Add(selfDog);
            animals.Add(selfCat);
            animals.Add(momDog);
            animals.Add(dadCat);
            animals.Add(dadDog);
            animals.Add(momCat);

            animals.Sort();
            // animals.Sort(new AnimalComparerByWeight());

            Console.WriteLine("Sorted animals:");
            foreach (var a in animals)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("-----------------");
            #endregion


            #region Variance
            // C<Animal> ca = new C<Dog>();

            // ca.Get() // OK
            // Kan kun returnere Dog-objekter, 
            // da ca peger på et objekt af type C<Dog>

            // ca.Set(new Cat(...)) // NOT OK
            // er et validt kald på ca (har typen C<Animal>), 
            // MEN duer ikke i.f.t. et objekt af typen C<Dog>


            // C<Dog> cd = new C<Animal>();

            // cd.Get() // NOT OK
            // Kan returnere andet end Dog-objekter, 
            // da cd peger på et objekt af type C<Animal>

            // cd.Set(new Dog(...)) // OK
            // Set kan kun kaldes med Dog-objekt, og objektet
            // cd peger på kan godt rumme Dog-objekter (og andre typer)


            ICGet<Animal> icga = new C<Dog>();
            ICSet<Dog> icsd = new C<Animal>();


            List<Dog> dogs = new List<Dog>();
            dogs.Add(selfDog);
            dogs.Add(momDog);
            dogs.Add(dadDog);

            //// Vi kan sortere en Dog-liste med en IComparer<Animal>
            dogs.Sort(new AnimalComparerByWeight());

            Console.WriteLine("Sorted dogs:");
            foreach (var d in dogs)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine("-----------------");
            #endregion



            Console.WriteLine("Done - press any key to shut down the app");
            Console.ReadKey();
        }
    }
}

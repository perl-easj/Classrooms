using System;
using System.Collections.Generic;

namespace ClassroomA
{
    //public class FamilyRelation
    //{
    //    private Animal _self;
    //    private Animal _father;
    //    private Animal _mother;
    //    private List<Animal> _children;

    //    public FamilyRelation(Animal self, Animal father, Animal mother)
    //    {
    //        _self = self;
    //        _father = father;
    //        _mother = mother;
    //        _children = new List<Animal>();
    //    }

    //    public Animal Self
    //    {
    //        get { return _self; }
    //    }

    //    public Animal Father
    //    {
    //        get { return _father; }
    //    }

    //    public Animal Mother
    //    {
    //        get { return _mother; }
    //    }

    //    public List<Animal> Children
    //    {
    //        get { return _children; }
    //    }

    //    public void AddChild(Animal child)
    //    {
    //        _children.Add(child);
    //    }

    //    public void PrintNamesOfParents()
    //    {
    //        Console.WriteLine(_father.Name + " and " + _mother.Name);
    //    }
    //}

    public class FamilyRelation<T> where T : Animal
    {
        private T _self;
        private T _father;
        private T _mother;
        private List<T> _children;

        public FamilyRelation(T self)
        {
            _self = self;
            _father = null;
            _mother = null;
            _children = new List<T>();
        }

        public FamilyRelation(T self, T father, T mother)
        {
            _self = self;
            _father = father;
            _mother = mother;
            _children = new List<T>();
        }

        public T Self
        {
            get { return _self; }
        }

        public T Father
        {
            get { return _father; }
        }

        public T Mother
        {
            get { return _mother; }
        }

        public List<T> Children
        {
            get { return _children; }
        }

        public void AddChild(T child)
        {
            _children.Add(child);
        }

        public void PrintNamesOfParents()
        {
            Console.WriteLine(_father.Name + " and " + _mother.Name);
        }
    }
}


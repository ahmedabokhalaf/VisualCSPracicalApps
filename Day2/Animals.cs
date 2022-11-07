using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    delegate void Notify(Animals animal);
    enum Type
    {
        Mammals, Birds
    }
    class Animals
    {
        public event Notify Notify;
        //public string Name { get; set; }
        public int Age { get; set; }
        public Type AnimalType { get; set; }
        public bool IsDied { get; set; }
        public void Die()
        {
            Notify.Invoke(this);
            Console.WriteLine($"This Animal is Died");
        }
    }
    class Lion : Animals
    {
        public Lion():this(5, false)
        {
            //Name = "Lion";
        }
        public Lion(int _Age, bool _IsDied)
        {
            Age = _Age;
            AnimalType = Type.Mammals;
            IsDied = _IsDied;
        }
        public override string ToString()
        {
            return $"This is Lion\nIts age is {Age}\nIts Follow {AnimalType}\n-----------------------------";
        }
    }
    class Sparrow : Animals
    {
        public Sparrow() : this(2,false) 
        {
            //Name = "Sparrow";
        }
        public Sparrow(int _Age, bool _IsDied)
        {
            Age = _Age;
            AnimalType = Type.Birds;
            IsDied = _IsDied;
        }
        public override string ToString()
        {
            return $"This is Sparrow\nIts age is {Age}\nIts Follow {AnimalType}\n-----------------------------";
        }
    }
    class Elephant : Animals
    {
        public Elephant() : this(10, false) 
        {
            //Name = "ELephant";
        }
        public Elephant(int _Age, bool _IsDied)
        {
            Age = _Age;
            AnimalType = Type.Mammals;
            IsDied = _IsDied;
        }
        public override string ToString()
        {
            return $"This is Elephant\nIts age is {Age}\nIts Follow {AnimalType}\n-----------------------------";
        }
    }
    class Pigeon : Animals
    {
        public Pigeon() : this(1, false) 
        {
            //Name = "Pigeon";
        }
        public Pigeon(int _Age, bool _IsDied)
        {
            Age = _Age;
            AnimalType = Type.Birds;
            IsDied = _IsDied;
        }
        public override string ToString()
        {
            return $"This is Pigeon\nIts age is {Age}\nIts Follow {AnimalType}\n-----------------------------";
        }
    }
}

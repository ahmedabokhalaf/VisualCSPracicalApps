using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    class AnimalAgeException : Exception
    {
        public AnimalAgeException(string msg) : base(msg)
        {

        }
    }
    #region OldZoo
    //class Zoo:List<Animals>/*, IReadOnlyCollection<Animals>*/
    //{
    //    public List<Animals> Birds { get; set; }
    //    public List<Animals> Mammals { get; set; }

    //    //public IReadOnlyList<Animals> AnimalBirds
    //    //{
    //    //    set
    //    //    {
    //    //        foreach (Animals animal in this)
    //    //        {
    //    //            if (animal.AnimalType == Type.Birds)
    //    //            {
    //    //                Birds.Add(animal);
    //    //            }
    //    //        }
    //    //    }
    //    //    get
    //    //    {
    //    //        return Birds;
    //    //    }
    //    //}
    //    //public IReadOnlyList<Animals> AnimalMammals
    //    //{
    //    //    set
    //    //    {
    //    //        foreach (Animals animal in this)
    //    //        {
    //    //            if (animal.AnimalType == Type.Mammals)
    //    //            {
    //    //                Mammals.Add(animal);
    //    //            }
    //    //        }
    //    //    }
    //    //    get
    //    //    {
    //    //        return Mammals;
    //    //    }
    //    //}

    //    public Zoo()
    //    {
    //        Birds = new List<Animals>();
    //        Mammals = new List<Animals>();
    //    }
    //    public new void Add(Animals animal)
    //    {
    //        if (animal.Age <= 10)
    //        {
    //            if (animal.AnimalType == Type.Birds)
    //            {
    //                Birds.Add(animal);
    //                base.Add(animal);
    //            }
    //            else
    //            {
    //                Birds.Add(animal);
    //                base.Add(animal);
    //            }
    //        }
    //        else
    //            throw new AnimalAgeException("Animal Age can't be more than 10 Years");         
    //    }

    //    //public Animals GetBirds (Animals animal)
    //    //{
    //    //    if (animal.AnimalType == Type.Birds)
    //    //    {
    //    //        return animal;
    //    //    }
    //    //    return null;
    //    //}
    //}
    #endregion

    #region NewZoo
    class Zoo
    {
        public List<Animals> Animals { get; set; }
        List<Animals> ZooBirds { get; set; }
        List<Animals> ZooMammals { get; set; }
        public IReadOnlyCollection<Animals> Birds
        {
            get
            {
                return ZooBirds;
            }
        } 
        public IReadOnlyCollection<Animals> Mammals
        {
            get
            {
                return ZooMammals;
            }
        }
        public Zoo()
        {
            Animals = new List<Animals>();
            ZooBirds = new List<Animals>();
            ZooMammals = new List<Animals>();
        }
        public void Add(Animals animal)
        {
            if (animal.Age <= 10)
            {
                Animals.Add(animal);
                if (animal.AnimalType == Type.Birds)
                {
                    ZooBirds.Add(animal);
                }
                else if (animal.AnimalType == Type.Mammals)
                {
                    ZooMammals.Add(animal);
                }
            }
            else
                throw new AnimalAgeException("Animal Age can't be more than 10 Years");
        }

        public void Remove(Animals animal)
        {
            
            Animals.Remove(animal);
        }
    }
    #endregion
}

using System;

namespace DogInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            GermanShepard max = new GermanShepard();
            max.Origin = "California";
            max.Name = "Max";
            max.Birth = new DateOnly(2017, 10, 10);
            max.DogGenderProberty = gender.female;
            max.Weight = 32.54;
            max.SecurityGuard = false;
            max.DogSize = size.large;
            max.DogTraningAbility = traningAbility.goodBoy;
            max.DisplayDogInfo();
            max.Sit(max.Name);
            max.Eat();
            max.SayHi(max.Name);
        }
    }

    class Animal
    {
        private string name;
        private DateOnly birth;
        private string origin;

        public string Name { get { return name; } set { name = value; } }
        public DateOnly Birth { get { return birth; } set { birth = value; } }
        public string Origin { get { return origin; } set { origin = value; } }

    }
    interface Idog
    {
        public void Eat();
        public void Drink();
        public void Sit();
        public void SayHi();

    }
    class GermanShepard : Animal, Idog
    {

        #region Propertys
        private gender DogGender;
        private double weight;
        private bool securityGuard;
        private traningAbility dogTraningAbility;
        private size dogSize;

        public gender DogGenderProberty { get { return DogGender; } set { DogGender = value; } }
        public double Weight { get { return weight; } set { weight = value; } }
        public bool SecurityGuard { get { return securityGuard; } set { securityGuard = value; } }
        public traningAbility DogTraningAbility { get { return dogTraningAbility;} set { dogTraningAbility = value; } } 
        public size DogSize { get { return dogSize; } set { dogSize = value; } }
        #endregion
        public void Drink()
        {
            Console.WriteLine("Dog is Drinking...");
        }
        public void Drink(string name)
        {
            Console.WriteLine($"{name} is D9rinking...");
        }
        public void Eat()
        {
            Console.WriteLine($"Dog is eating.");
        }
        public void Eat(string name)
        {
            Console.WriteLine($"{name} is eating.");
        }
        public void SayHi()
        {
            Console.WriteLine($"Dog said hi in dogs languages.");
        }
        public void SayHi(string name)
        {
            Console.WriteLine($"{name} said hi in dogs languages.");
        }
        public void Sit()
        {
            Console.WriteLine($"Dog is siting.");
        }
        public void Sit(string name)
        {
            Console.WriteLine($"{name} is siting.");
        }

        public void DisplayDogInfo()
        {
            Console.WriteLine($"Dog Name is:{Name} and it is from:{Origin}\n"+
                              $"was born on {Birth.ToShortDateString()}\n" +
                              $"{Name} is {DogGender} and weights {weight} Kilos and size is {dogSize}");

        }

    }
    enum gender
    {
        male,
        female
    }
    enum traningAbility
    {
        none,
        basic,
        medium,
        goodBoy
    }
    enum size
    {
        small,
        medium,
        large
    }

}

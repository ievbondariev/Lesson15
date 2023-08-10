namespace Lesson15
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void SayHi()
        {
            Console.WriteLine("hi");
        }

        public override string ToString()
        {
            var present = $"Hi, my name is {Name}";
            return present;
        }
        public virtual int Method()
        {
            return 5;
        }
        public Animal() { }
    }

    public class Cat : Animal
    {
        public string Breed { get; set; }
        public override void SayHi()
        {
            Console.WriteLine("Meow");
        }
        public override int Method()
        {
            return 6;
        }
        public Cat()
        {

        }
    }
    public class Dog : Animal
    {
        public override void SayHi()
        {
            Console.WriteLine("Gav");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal cat = new Cat();
            //cat.Method();
            Animal animal = new Animal();
            animal.Name = "Test";
            animal.SayHi();
            Console.WriteLine(animal.ToString());
            Animal cat = new Cat();
            Animal dog = new Dog();
            Cat cat2 = (Cat)cat;
            //Dog dog1 = (Dog)cat;
            Dog dog2 = cat as Dog;
            cat2.Breed = "catttt";
            cat.SayHi();
            dog.SayHi();
        }
    }
}
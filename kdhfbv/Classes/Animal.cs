namespace kdhfbv.Classes
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public string Gender { get; set; }
        public string Kind { get; set; }

        public virtual void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }
}

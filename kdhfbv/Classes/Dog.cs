namespace kdhfbv.Classes
{
    public class Dog : Animal
    {
        public string Breed { get; set; }
        public string Gender { get; set; }
        public string Kind { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Собаки едят дрова");
        }
    }
}

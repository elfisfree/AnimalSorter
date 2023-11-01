namespace kdhfbv.Classes
{
    public class Cat : Animal
    {
        public string Color { get; set; }
        public string Breed { get; set; }
        public string Gender { get; set; }
        public string Kind { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Коты едят корм и мышей");
        }
    }
}

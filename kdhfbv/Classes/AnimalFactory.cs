namespace kdhfbv.Classes
{
    public class AnimalFactory
    {
        public Animal CreateAnimal(string type)
        {
            Animal animal = null;

            switch (type.ToLower())
            {
                case "dog":
                    animal = new Dog();
                    break;
                case "cat":
                    animal = new Cat();
                    break;
                case "tiger":
                    animal = new Cat();
                    break;
                default:
                    Console.WriteLine($"Неправильный вывод: {type}");
                    break;
            }

            return animal;
        }
    }
}

using kdhfbv.Classes;
public class Program
{
    public static void Main(string[] args)
    {
        AnimalFactory animalFactory = new AnimalFactory();
        AnimalSorter animalSorter = new AnimalSorter();

        List<Animal> animals = new List<Animal>();
        animals.Add(animalFactory.CreateAnimal("dog"));
        animals[0].Name = "Голди";
        animals[0].Age = 3;
        animals[0].Gender = "Сучка";
        animals[0].Breed = "Джек Рассел";
        animals[0].Color = "Серый";
        animals[0].Kind = "Собака";

        animals.Add(animalFactory.CreateAnimal("cat"));
        animals[1].Name = "Абобуз";
        animals[1].Age = 5;
        animals[1].Gender = "Самка";
        animals[1].Breed = "Дворняга";
        animals[1].Color = "Черная с белыми пятнышками";
        animals[1].Kind = "Кошка";

        animals.Add(animalFactory.CreateAnimal("human"));
        animals[2].Name = "Мерил Стрип";
        animals[2].Age = 74;
        animals[2].Gender = "Мраморная плитка. Дом видели? Как в Эрмитаже.";
        animals[2].Breed = "Еврей";
        animals[2].Color = "Белая";
        animals[2].Kind = "Человек";

        animals.Add(animalFactory.CreateAnimal("cat"));
        animals[3].Name = "Очкопус";
        animals[3].Age = 1;
        animals[3].Gender = "Самец";
        animals[3].Breed = "Сиамская";
        animals[3].Color = "Серый";
        animals[3].Kind = "Кошка";

        animals.Add(animalFactory.CreateAnimal("tiger"));
        animals[4].Name = "Евгеша";
        animals[4].Age = 13;
        animals[4].Gender = "Самец";
        animals[4].Breed = "Амурский тигр";
        animals[4].Color = "Оранжевый в черно-белую полоску";
        animals[4].Kind = "Тигр";

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("До сортировки списка");
            Console.WriteLine("-----------------");
            foreach (Animal animal in animals)
            {
                Console.WriteLine($"Это {animal.Kind} {animal.Name}  Порода: {animal.Breed}  Пол: {animal.Gender}  Цвет кожи/шерсти: {animal.Color}  Возраст: {animal.Age} лет");
                animal.Eat();
                Console.WriteLine("-----------------");
            }
            Console.WriteLine("-----------------");
            Console.WriteLine(" Для сортировки списка нажмите с");
            var cont = Console.ReadKey().Key;
            if (cont == ConsoleKey.C || cont == ConsoleKey.C)
            {
                Console.WriteLine(" После сортировки по возрасту:");
                Console.WriteLine("-----------------");
                animalSorter.BubbleSort(animals);
                foreach (Animal animal in animals)
                {
                    Console.WriteLine($"Это {animal.Kind} {animal.Name}  Порода: {animal.Breed}  Пол: {animal.Gender}  Цвет: {animal.Color}  Возраст: {animal.Age} лет");
                    animal.Eat();
                    Console.WriteLine("-----------------");
                }
            }



            Console.WriteLine("Для выхода из приложения нажмите 'q', для продолжения - любую другую клавишу");
            var key = Console.ReadKey().Key;

            if (key == ConsoleKey.Q || key == ConsoleKey.Q)
            {
                exit = true;
            }
        }
    }
}
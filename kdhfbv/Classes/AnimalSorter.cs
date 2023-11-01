namespace kdhfbv.Classes
{
    public class AnimalSorter
    {
        public void BubbleSort(List<Animal> animals)
        {
            for (int i = 0; i < animals.Count - 1; i++)
            {
                for (int j = 0; j < animals.Count - 1 - i; j++)
                {
                    if (animals[j].Age > animals[j + 1].Age)
                    {
                        Animal temp = animals[j];
                        animals[j] = animals[j + 1];
                        animals[j + 1] = temp;
                    }
                }
            }
        }
    }
}

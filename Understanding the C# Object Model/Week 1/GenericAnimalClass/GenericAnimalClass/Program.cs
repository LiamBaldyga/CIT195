namespace GeneralAnimalClass
{
    class Animal<T>
    {
        private T data;
        
        public Animal(T data)
        {
            this.data = data;
        }

        public T getAnimal()
        {
            return data;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal<string> animalName = new Animal<string>("Dog");
            Animal<string> animalHabitat = new Animal<string>("House");
            Animal<bool> endangered = new Animal<bool>(false);
            Animal<bool> extinct = new Animal<bool>(false);
            Animal<int> averageLifespan = new Animal<int>(13);

            Console.WriteLine($"Animal: {animalName.getAnimal()} \nHabitat: {animalHabitat.getAnimal()} \nEndangered?: {endangered.getAnimal()} \nExtinct?: {extinct.getAnimal()} \nAverage Lifespan: {averageLifespan.getAnimal()}");
        }
    }
}

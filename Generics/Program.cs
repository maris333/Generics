using System;

public class Program
{
    // TODO: Implement a class that satisfies both DogRepo and CatRepo using generics.
    // TODO: Implement a method called "Remove" that removes an item from the list by its index.
    public static void Main()
    {
        var dogRepo = new DogRepo();
        dogRepo.Add(new Dog());

        var dog = dogRepo.Get(0);
        Console.WriteLine(dog.Name);

        var catRepo = new CatRepo();
        catRepo.Add(new Cat { Name = "Trixie" });

        var cat = catRepo.Get(0);
        Console.WriteLine(cat.Name);
    }

    public class DogRepo
    {
        private Dog[] array = new Dog[5];
        private int currentIndex = 0;

        public void Add(Dog dog)
        {
            if (currentIndex < array.Length)
            {
                array[currentIndex] = dog;
                currentIndex++;
            }
        }

        public Dog Get(int index)
        {
            if (index >= 0 && index < array.Length)
            {
                return array[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }

    public class CatRepo
    {
        private Cat[] array = new Cat[5];
        private int currentIndex = 0;

        public void Add(Cat cat)
        {
            if (currentIndex < array.Length)
            {
                array[currentIndex] = cat;
                currentIndex++;
            }
        }

        public Cat Get(int index)
        {
            if (index >= 0 && index < array.Length)
            {
                return array[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }

    public class Dog
    {
        public string Name { get; set; } = "Spot";
    }

    public class Cat
    {
        public string Name { get; set; } = "Freckles";
    }
}
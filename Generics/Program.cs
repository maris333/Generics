using System;
using static Program;

public class Program
{
    // TODO: Implement a class that satisfies both DogRepo and CatRepo using generics.
    // TODO: Implement a method called "Remove" that removes an item from the list by its index.
    public static void Main()
    {
        var dogRepo = new Repo<Dog>();
        dogRepo.Add(new Dog());

        var dog = dogRepo.Get(0);
        Console.WriteLine(dog.Name);

        var catRepo = new Repo<Cat>();
        catRepo.Add(new Cat());
        catRepo.Remove(0);

        var cat = catRepo.Get(0);
        Console.WriteLine(cat.Name);
    }

    public class Repo<T>
    {
        private T[] array = new T[5];
        private int currentIndex = 0;

        public void Add(T item)
        {
            if (currentIndex < array.Length)
            {
                array[currentIndex] = item;
                currentIndex++;
            }
        }

        public T Get(int index)
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

        public void Remove(int index)
        {
            if (index >= 0 && index < array.Length)
            {
                var tmp = new List<T>(array);
                tmp.RemoveAt(index);
                array = tmp.ToArray();
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
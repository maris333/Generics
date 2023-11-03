public class Program
{
    public static void Main()
    {
        var dogRepo = new Repo<Dog>();
        dogRepo.Add(new Dog(), 0);

        var dog = dogRepo.Get(0);
        Console.WriteLine(dog.Name);

        var catRepo = new Repo<Cat>();
        catRepo.Add(new Cat() { Name = "Trixie" }, 0);
        catRepo.Remove(0);

        var cat = catRepo.Get(0);
        Console.WriteLine(cat.Name);
    }

    public class Repo<T>
    {
        private T[] array = new T[5];

        public void Add(T item, int index)
        {
            if (index >= 0 && index < array.Length)
            {
                array[index] = item;
            }
            else
            {
                throw new IndexOutOfRangeException();
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
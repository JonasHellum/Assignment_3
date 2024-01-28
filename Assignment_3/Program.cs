namespace Assignment_3;

class Program
{
    static void Main(string[] args)
    {
        List<Pet> pets = new List<Pet>();
        
        pets.Add(new Fish("Blud"));
        pets.Add(new Dog("Buddy"));
        pets.Add(new Cat("Mau"));
        
        foreach (Pet pet in pets)
        {
            Console.WriteLine($"Name: {pet.Name}, Description: {pet.Description}, Trick: {pet.Trick}, Noise: {pet.Noise}");
        }
    }
}
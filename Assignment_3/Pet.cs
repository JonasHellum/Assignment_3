namespace Assignment_3;

public class Pet
{
    public string Name { get; }
    public string Description { get; }
    public string Trick { get; }
    public string Noise { get; }
    
    
    public Pet(string name, string description, string trick, string noise)
    {
        Name = name;
        Description = description;
        Trick = trick;
        Noise = noise;
    }
}
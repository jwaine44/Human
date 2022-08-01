public class Human
{
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    public int Health;

    // Add a constructor that takes a value to set Name, and set the remaining fields to default values
    public Human(string val)
    {
        Name = val;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        Health = 100;
    }
    
    // Add a constructor to assign custom values to all fields
    public Human(string val, int strengthNum, int intelligenceNum, int dexNum, int healthNum)
    {
        Name = val;
        Strength = strengthNum;
        Intelligence = intelligenceNum;
        Dexterity = dexNum;
        Health = healthNum;
    }
    
    // Build Attack method

    public int Attack(Human target)
    {
        target.Health -= (Strength * 5);
        return target.Health;
    }
}


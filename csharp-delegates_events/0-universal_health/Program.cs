/// <summary>
/// Represents a player with a name, maximum health, and current health.
/// </summary>
public class Player
{
    /// <summary>
    /// The player's name.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// The player's maximum health points.
    /// </summary>
    public float MaxHp { get; }

    private float hp;

    /// <summary>
    /// Initializes a new instance of the <see cref="Player"/> class.
    /// </summary>
    /// <param name="name">The player's name.</param>
    /// <param name="maxHp">The player's maximum health points.</param>   

    public Player(string name = "Player", float maxHp = 100f)
    {
        Name = name;
        MaxHp = maxHp > 0 ? maxHp : 100f;
        if (MaxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        hp = MaxHp;
    }

    /// <summary>
    /// Prints the player's current health and maximum health to the console.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{Name} has {hp} / {MaxHp} health");
    }
}
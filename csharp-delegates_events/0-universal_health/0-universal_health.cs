using System;

/// <summary>
/// Represents a class
/// </summary>
public class Player
{
    /// <summary>
    /// The player's name.
    /// </summary>
    private string? name;

    /// <summary>
    /// The player's maximum health points.
    /// </summary>
    private float? maxHp;

    private float? hp;

    /// <summary>
    /// Initializes a new instance of the <see cref="Player"/> class.
    /// </summary>
    /// <param name="name">The player's name.</param>
    /// <param name="maxHp">The player's maximum health points.</param>   

    public Player(string name = "Player", float? maxHp = 100f)
    {
        this.name = name;
        //MaxHp = maxHp > 0 ? maxHp : 100f;
        if (maxHp > 0)
        {
            this.maxHp = maxHp;
            
        }else{
        this.maxHp = 100f;
        Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        hp = this.maxHp;
    }

    /// <summary>
    /// Prints the player's current health and maximum health to the console.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}
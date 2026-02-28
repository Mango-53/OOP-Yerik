namespace CharacterCreator;

public class Character
{
    private string name;
    private float health;
    private float maxHealth;
    private float heal;
    private float damage;
    
    public  Character()
    {
        Console.WriteLine("Write the character's name\n");
        name = Console.ReadLine();
        health = 100;
        maxHealth = 100;
    }

    public void ShowStats()
    {
        Console.WriteLine($"Name: {name}\n");
        Console.WriteLine($"Health: {health}\n");
        Console.WriteLine($"Max Health: {maxHealth}\n");
    }

    public void ReceiveDamage()
    {
        Console.WriteLine($"Write how much damage the character received\n");
        damage = float.Parse(Console.ReadLine());
        if (damage >= health)
        {
            this.Lose();
        } else
        {
            health -= damage;
        }
    }

    public void Heal()
    {
        Console.WriteLine("Write how much health the character healed\n");
        heal = float.Parse(Console.ReadLine());
        if ((heal+health) >= maxHealth)
        {
            health = maxHealth;
        }
        else
        {
            health += heal;
        }
    }

    public void Lose()
    {
        Console.WriteLine($"You lost {name}!\n");
    }
}
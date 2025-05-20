namespace SmartBattleArena;

public class BattleRobot : IPowerable, IMoveable, IAttackable
{
    public bool IsOn { get; private set; } = false;

    public void TurnOn()
    {
        IsOn = true;
        Console.WriteLine("BattleRobot is now ON");
    }

    public void TurnOff()
    {
        IsOn = false;
        Console.WriteLine("BattleRobot is now OFF");
    }

    public void MoveTo(string location)
    {
        if (!IsOn)
        {
            Console.WriteLine("Cannot move. The robot is OFF.");
            return;
        }

        Console.WriteLine($"Moving to {location}...");
    }

    public int Health { get; set; } = 100;

    public void TakeDamage(int amount)
    {
        Health -= amount;
        Console.WriteLine($"Took {amount} damage. Health: {Health}");
    }

    public void Heal(int amount)
    {
        Health += amount;
        Console.WriteLine($"Healed {amount}. Health: {Health}");
    }
}

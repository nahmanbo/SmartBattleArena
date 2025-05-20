namespace SmartBattleArena;

public class ArenaGate: IPowerable
{
    public bool IsOn { get; private set; } = false;

    public void TurnOn()
    {
        IsOn = true;
        Console.WriteLine("ArenaGate is now ON");
    }

    public void TurnOff()
    {
        IsOn = false;
        Console.WriteLine("ArenaGate is now OFF");
    }
}
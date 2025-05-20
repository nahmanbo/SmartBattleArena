namespace SmartBattleArena;

public interface IPowerable
{
    bool IsOn { get; }     
    void TurnOn();
    void TurnOff();
}
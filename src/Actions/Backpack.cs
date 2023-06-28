namespace Adventure;

public class Backpack : Action{
    private readonly IIventory _iventory;

    public Backpack(IIventory iventory)
    {
        _iventory = iventory;
    }

    public override string Name => Text.Language.Backpack;

    public override void Execute(string[] args){
        _iventory.List();
    }
}
namespace Adventure;

public class Gold : Item
{
    public int Value { get;protected set; }
    public override string Name {
        get {
            var ending = Value == 1 ? "" : "s";
            return $"{Value} {Text.Language.Gold}{ending}";
        }
        }


    public Gold(int value)
    {
        Value = value;
    }
}
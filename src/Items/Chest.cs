namespace Adventure;

public class Chest : Item, IIventory
{
    private readonly House _house;
    private readonly IIventory _iventory = new Iventory();

    public override string Name => Text.Language.Chest;
    public bool Locked = true;

    public Chest(Item?[] items, House house)
    {
        CanTake = false;
        _house = house;

        foreach (var item in items)
        {
            if (item != null)
            {
                _iventory.Add(item);
            }
        }
    }

    public override void Use(string source){
        if(source == Text.Language.Key){
            var items = List();

            if (Locked)
            {
                Console.WriteLine(Text.Language.UnlockChest);
            }
            if(items.Count == 0){
                Console.WriteLine(Text.Language.ChestEmpty);
            }
            else{
                Console.WriteLine(Text.Language.ChestFound);
                foreach (var itemTmp in items)
                {
                    var itemName = itemTmp.Name;
                     var item = Take(itemName);
            if (item != null)
            {

                    _house.Player.Add(item);
            }
                }
            }
        }

    }

    public int Total => _iventory.Total;

    public void Add(Item item)
    {
        _iventory.Add(item);
    }

    public bool Contains(string itemName)
    {
        return _iventory.Contains(itemName);
    }

    public Item? Find(string itemName, bool remove = false)
    {
        return _iventory.Find(itemName, remove);
    }

    public List<Item> List()
    {
       return _iventory.List();
    }

    public void Remove(Item item)
    {
        _iventory.Remove(item);
    }

    public Item? Take(string itemName)
    {
        return _iventory.Take(itemName);
    }

    public void Use(string itemName, string? source = "")
    {
        _iventory.Use(itemName, source);
    }
}
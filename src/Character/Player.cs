namespace Adventure;

public class Player : Character, IIventory
{
    private readonly IIventory _iventory;
    public Player(string name) : base(name)
    {
        _iventory = new Iventory();
    }

    public int Total => _iventory.Total;

    public void Add(Item item)
    {
        _iventory.Add(item);
    }

    public void Remove(Item item)
    {
        _iventory.Remove(item);
    }

    public List<Item> List()
    {
       return _iventory.List();
    }

    public Item? Find(string itemName, bool remove = false)
    {
        return _iventory.Find(itemName, remove);
    }

    public bool Contains(string itemName)
    {
        return _iventory.Contains(itemName);
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
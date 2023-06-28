namespace Adventure;

public interface IIventory{
    int Total {get;}
    void Add(Item item);
    void Remove(Item item);
    List<Item> List();
    Item? Find(string itemName, bool remove = false);
    bool Contains(string itemName);
    Item? Take(string itemName);
    void Use(string itemName, string? source = "" );
}
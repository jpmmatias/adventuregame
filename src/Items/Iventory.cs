namespace Adventure;

public class Iventory: IIventory
{
    private List<Item> Items { get;  } = new();

    public int Total => Items.Count;

    public void Add(Item item)
    {
        Items.Add(item);
    }

    public void Remove(Item item)
    {
        Items.Remove(item);
    }

    public List<Item> List()
    {
        return Items;
    }

   public Item? Find(string itemName)
    {

        foreach (var item in Items)
        {

            if (item?.Name == itemName)
            {

                return item;

            }


        }

        return null;

    }

    public Item? Find(string itemName, bool remove)
    {

        var item = Find(itemName);

        if (item != null && remove)
        {
            Remove(item);
        }

        return item;

    }

    public bool Contains(string itemName)
    {
    return Find(itemName) != null;
    }

    public Item? Take(string itemName)
    {
        return Find(itemName, true);
    }

    public void Use(string itemName, string? source = "" )
    {
        var item = Find(itemName);
        if (item !=null )
        {

            item.Use(source ?? "");

         if (item.SingleUse)
         {
            Items.Remove(item);
         }

         return;
        }

        Console.WriteLine(String.Format(Text.Language.NoItem, itemName));
    }



}
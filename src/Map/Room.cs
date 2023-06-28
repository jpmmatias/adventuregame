using System.Text;

namespace Adventure;

public class Room : IIventory
{

  private readonly IIventory _iventory = new Iventory();

    public string Name { get; set; } = Text.Language.DefaultRoomName;
    public string Description { get; set; } = Text.Language.DefaultRoomDescription;

    public bool Visited { get; set; } = false;

  public Dictionary<Directions, int> Neighbors { get; set; } = new()
  {
    { Directions.North, -1 },
    { Directions.South, -1 },
    { Directions.East, -1 },
    { Directions.West, -1},
    { Directions.None, 0}
  };

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
      return  _iventory.Take(itemName);
    }

    public override string ToString()
 {
     var sb = new StringBuilder();

     if (Visited)
     {
         sb.Append(string.Format(Text.Language.RoomOld, Name));
     }
     else
     {
         sb.Append(string.Format(Text.Language.RoomNew, Name));
         Visited = true;
     }

     var names = Enum.GetNames(typeof(Directions));

     var directions =  (from p in names where Neighbors[(Directions)Enum.Parse(typeof(Directions), p)] != -1 select p).ToList();

    directions.Remove(Directions.None.ToString());

     var description = string.Format(Description, Text.Language.JoinedWordList(directions.ToArray(), Text.Language.And));

    sb.Append(description);

    if (_iventory.Total > 0)
    {
       var items = _iventory.List();
       var pluralPre = items.Count > 1 ? Text.Language.Are : Text.Language.Is;

       var pluralPost = items.Count > 1 ? Text.Language.Plural : string.Empty;
    var text = string.Format(Text.Language.TotalItems, pluralPre, items.Count, pluralPost);
       sb.Append(text);
       var itemsNames = items.Select(i => i.Name).ToArray();
      sb.Append(Text.Language.JoinedWordList(itemsNames, Text.Language.And));

    }



    return sb.ToString();
 }

    public void Use(string itemName, string? source = "")
    {
        throw new NotImplementedException();
    }
}
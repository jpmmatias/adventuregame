using Adventure;

Console.WriteLine("Chosse your language:");
Console.WriteLine("1. English");
Console.WriteLine("2. Português");

var languageChoice =  Console.ReadLine();
Text.SetLanguage(languageChoice);

Console.WriteLine(Text.Language.ChoseYourName);

var name = Console.ReadLine();
Player player;

if (name == String.Empty){
    Console.WriteLine(Text.Language.SentNoName);
    name = Text.Language.DefualtName;
    Console.WriteLine( Text.Language.WeWillCallYouMessage + name);
}

player = new Player(name);

Console.WriteLine(Text.Language.Welcome, player.Name);

var house = new House(player);
house.CreateRooms(3,3);
house.DecorateRooms();
var items = new List<Item>(){
    new Key(house),
    new Chest(new[] {new Gold(100)}, house),
};

house.PopulateRooms(items);

Actions.Instance.Register(new Go(house));
Actions.Instance.Register(new Backpack(player));
Actions.Instance.Register(new Take(house));
Actions.Instance.Register(new Use(house));

house.GoToStartingRoom();

var run = true;

Room lastRoom = null;

while(run){
    if(lastRoom != house.CurrentRoom){
        Console.WriteLine(house.CurrentRoom.ToString());
        lastRoom = house.CurrentRoom;
    }

    Console.WriteLine(Text.Language.WhatToDo);
    var input = Console.ReadLine().ToLower();

    if (input == Text.Language.Quit )
        run = false;
    else
        Actions.Instance.Execute(input.Split(" "));
}


namespace Adventure;

public class English : Language
{
    public English()
    {
        Welcome = "Wellcome to your Adventure {0}!";
        ChoseYourName = "Hello, whats your name?";
        SentNoName = "You did not enter a name";
        WeWillCallYouMessage = "So we will call you ";
        DefualtName = "No Name";
        DefaultRoomName = "Room {0} ({1}, {2})";
        DefaultRoomDescription = "You are in a room with doors to the {0}.";
        ActionError = "You can't do that";
        Go = "Go";
        GoError = "You can't go that way";
        WhatToDo = "What do you want to do?";
        Quit = "quit";
        RoomNew = "You entered a new {0}";
        RoomOld = "You returned to the {0}";
        And = "and";
        Coma = ",";
        Space = " ";
        RoomDescriptions = new List<string>{
            "normal",
            "dark",
            "bright",
            "cold",
            "hot",
            "wet",
            "dry",
            "scary",
            "creepy",
            "smelly",
            "stinky",
            "strange",
        };

    NoItem = "There is no {0} here.";

    Backpack = "Backpack";

    Chest = "chest";

    UnlockChest = "You unloked the chest";

    Key = "key";

    DontHaveItem = "You dont have items";

    TheseAreYourItems = "These are your items";

    ChestEmpty = "The chest is empty";

    ChestFound = "You found a chest";

    Gold = "gold";

    Coin = "coin";

    Coins = "coins";

    Plural = "s";

    Is = "is";

    Are = "are";

    TotalItems = "There {0} {1} item{2} in the room: ";

    Period = ".";

    Take = "take";

    TakeError = "You can't take that";

    NotTaken = "You did not take anything";

    TookDescription = "You took the {0}";

    CantTakeDescription = "You can't take the {0}";

    Use = "use";

    UseError = "You can't use that";

    UseDescription = "You used the item";

    CantUseDescription = "You can't use the item";

    UseSuccess = "You used the item";

}
}
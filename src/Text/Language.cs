namespace Adventure;

public abstract partial class Language{
     public string Welcome {get; protected set;} = "";
    public string ChoseYourName{get; protected set;} = "";

    public string SentNoName {get; protected set;} = "";

    public string WeWillCallYouMessage {get; protected set;} = "";
    public string DefualtName {get; protected set;} = "";

    public string DefaultRoomName {get; protected set;} = "";

    public string DefaultRoomDescription {get; protected set;} = "";

    public string ActionError {get; protected set;} = "";

    public string Go {get; protected set;} = "";
    public string GoError {get; protected set;} = "";

    public string WhatToDo {get; protected set;} = "";

    public string Quit {get; protected set;} = "";

    public string RoomNew {get; protected set;} = "";
    public string RoomOld {get; protected set;} = "";
    public string And {get; protected set;} = "";
    public string  Coma {get; protected set;} = "";
    public string Space {get; protected set;} = "";

    public List<string> RoomDescriptions {get; protected set;} = new();

    public string NoItem {get; protected set;} = "";

    public string Backpack {get; protected set;} = "";

    public string Chest {get; protected set;} = "";

    public string UnlockChest {get; protected set;} = "";

    public string Key {get; protected set;} = "";

    public string DontHaveItem {get; protected set;} = "";

    public string TheseAreYourItems {get; protected set;} = "";

    public string ChestEmpty {get; protected set;} = "";

    public string ChestFound {get; protected set;} = "";

    public string Gold {get; protected set;} = "";

    public string Coin {get; protected set;} = "";

    public string Coins {get; protected set;} = "";

    public string Plural {get; protected set;} = "";

    public string Is {get; protected set;} = "";

    public string Are {get; protected set;} = "";

    public string TotalItems {get; protected set;} = "";

    public string Period {get; protected set;} = "";

    public string Take {get; protected set;} = "";

    public string TakeError {get; protected set;} = "";

    public string NotTaken {get; protected set;} = "";

    public string TookDescription {get; protected set;} = "";

    public string CantTakeDescription {get; protected set;} = "";

    public string Use {get; protected set;} = "";

    public string UseError {get; protected set;} = "";

    public string UseDescription {get; protected set;} = "";

    public string CantUseDescription {get; protected set;} = "";

    public string UseSuccess {get; protected set;} = "";



}
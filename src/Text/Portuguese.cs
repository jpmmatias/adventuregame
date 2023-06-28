namespace Adventure;

public class Portuguese : Language
{
    public Portuguese()
    {
        Welcome = "Bem vindo a sua aventura {0}!";
        ChoseYourName = "Olá, qual é o seu nome?";
        SentNoName = "Você não digitou um nome";
        WeWillCallYouMessage = "Então vamos te chamar de ";
        DefualtName = "Sem Nome";
        DefaultRoomName = "Sala {0} ({1}, {2})";
        DefaultRoomDescription = "Você está em uma sala com portas para o {0}.";
        ActionError = "Você não pode fazer isso";
        Go = "Ir";
        GoError = "Você não pode ir por esse caminho";
        WhatToDo = "O que você quer fazer?";
        Quit = "sair";
        RoomNew = "Você entrou {0}";
        RoomOld = "Você retornou para {0}";
        And = "e";
        Coma = ",";
        Space = " ";
        RoomDescriptions = new List<string>{
            "normal",
            "escuro",
            "brilhante",
            "frio",
            "quente",
            "molhado",
            "fedido",
            "estranho",
            "assustador",
           "seco",
            "úmido",
            "grudento",
        };

    NoItem = "Não há {0} aqui.";

    Backpack = "Mochila";

    Chest = "baú";

    UnlockChest = "Você destrancou o baú";

    Key = "chave";

    DontHaveItem = "Você não tem items";

    TheseAreYourItems = "Esses são seus items";

    ChestEmpty = "O baú está vazio";

    ChestFound = "Você encontrou um baú";

    Gold = "ouro";

    Coin = "moeda";

    Coins = "moedas";

    Plural = "s";

    Is = "é";

    Are = "são";

    TotalItems = "Tem {0} {1} item{2} na sala: ";

    Period = ".";

    Take = "pegar";

    TakeError = "Você não pode pegar isso";

    NotTaken = "Você não pegou nada";

    CantTakeDescription = "Você não pode pegar {0}";

    TookDescription = "Você pegou {0}";

    Use = "usar";

    UseError = "Você não pode usar isso";

    CantUseDescription = "Você não pode usar o item";

    UseDescription = "Você usou o item";

    UseSuccess = "Você usou o item";




 }
}

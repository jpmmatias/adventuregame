namespace Adventure;

public sealed class Actions{
    private static Actions? _instance ;
    private readonly Dictionary<string, Action> _actions = new();

    public static Actions Instance{
        get{
            _instance ??= new Actions();
            return _instance;
        }
    }

    private Actions(){


    }

    public void Register(Action action){
       var name = action.Name.ToLower();
         if(_actions.ContainsKey(name)){
            _actions[name] = action;
         }

        _actions.Add(name, action);
    }

    public void Remove(string name){
        _actions.Remove(name);
    }

    public void Execute(string[] args)
    {
        var actionName = args[0];

        if(_actions.ContainsKey(actionName)){
            _actions[actionName].Execute(args);
        }
        else{
           Console.WriteLine(Text.Language.ActionError);
        }
    }
}
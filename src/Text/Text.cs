namespace Adventure;

public static class Text {
    private static Language _language;

    public static Language Language{
        get{
            if(_language == null){
                throw new System.Exception("Language not set");
            }

            return _language;
        }
    }

    public static void SetLanguage(string choice){
        _language = GetLanguageByChoice(choice);
    }

    static private Language GetLanguageByChoice(string choice){
        return choice switch
        {
            "1" => new English(),
            "2" => new Portuguese(),
            _ => new English(),
        };
    }

}
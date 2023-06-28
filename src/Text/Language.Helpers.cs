using System.Text;

namespace Adventure;

public partial class Language
{
    private readonly StringBuilder _sb = new();

    public virtual string JoinedWordList(string[] words, string conjuction){
        _sb.Clear();

        for (int i = 0; i < words.Length; i++)
        {
          if(i > 0){
            _sb.Append(words.Length > 2 ? Coma + Space : Space);
          }

        if (i == words.Length - 1 && words.Length > 1){
                _sb.Append(conjuction + Space);
            }

        _sb.Append(words[i]);
        }

        return _sb.ToString();
    }


}
using UnityEngine;
using UnityEngine.UI;

public class LangControlEndScreen : UI
{
    [SerializeField] private Text QuitButt;
    [SerializeField] private Text TryButt;
    private void Start()
    {
        if (SetLang == "Ukrainian") SetUkrainian();
        else SetEnglish();
    }
    public override void SetUkrainian()
    {
        QuitButt.text = "Вийти";
        TryButt.text = "Ще раз";
    }

    public override void SetEnglish()
    {
        QuitButt.text = "Quit game";
        TryButt.text = "Try again";
    }
}

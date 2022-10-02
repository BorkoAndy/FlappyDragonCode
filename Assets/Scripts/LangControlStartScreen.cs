using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LangControlStartScreen : UI
{
    [SerializeField] private Text OptButt;
    [SerializeField] private Text QuitButt;
    [SerializeField] private Text StartButt;

    private void Start()
    {
        if (SetLang == "Ukrainian") SetUkrainian();
        else SetEnglish();
    }
    public override void SetUkrainian()
    {
        StartButt.text = "Вперед!";
        OptButt.text = "Параметри";
        QuitButt.text = "Вийти";
    }

    public override void SetEnglish()
    {
        StartButt.text = "Start";
        OptButt.text = "Options";
        QuitButt.text = "Quit";
    }      
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LangControlOptScr : UI
{
    [SerializeField] private Text logo;
    [SerializeField] private Text CanvLangText;    
    [SerializeField] private Text EngButtText;
    [SerializeField] private Text UaButtText;
    [SerializeField] private Text BackButtText;
    [SerializeField] private Text VolControlText;
    private void OnEnable() => GameController.OnLanguageSet += LanguageSet;
    
    private void OnDisable() => GameController.OnLanguageSet -= LanguageSet;

    private void Start() => LanguageSet();

    private void LanguageSet()
    {
        if (SetLang == "Ukrainian") SetUkrainian();
        else SetEnglish();
    }
    public override void SetUkrainian()
    {
        logo.text = "Параметри";
        CanvLangText.text = "Мова";
        EngButtText.text = "Англійська";
        UaButtText.text = "Українська";
        BackButtText.text = "Назад";
        VolControlText.text = "Гучність";
    }

    public override void SetEnglish()
    {
        logo.text = "Option screen";
        CanvLangText.text = "Language";
        EngButtText.text = "English";
        UaButtText.text = "Ukrainian";
        BackButtText.text = "Back";
        VolControlText.text = "Music volume";
    }
}

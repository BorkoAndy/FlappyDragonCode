using UnityEngine;

public abstract class UI : MonoBehaviour
{
    public static float volLevel = 1;
    public static string SetLang = "English";
    
    public abstract void SetEnglish();
    public abstract void SetUkrainian();    
}


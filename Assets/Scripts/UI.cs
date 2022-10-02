using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings.Switch;

public abstract class UI : MonoBehaviour
{
    public static float volLevel = 1;
    public static string SetLang = "English";
    
    public abstract void SetEnglish();
    public abstract void SetUkrainian();
    
}


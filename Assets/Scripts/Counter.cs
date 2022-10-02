using System;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    [SerializeField] private Text counter;
    public static int counterValue;    

    private void OnEnable() => Player.OnBlockerPass += increaseCounter;    
    private void OnDisable() => Player.OnBlockerPass -= increaseCounter;

    private void increaseCounter()
    {
        counterValue++;
        counter.text = counterValue.ToString();

        if (counterValue % 5 == 0)
            GameController.level++;
    }  
}




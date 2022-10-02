
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{        
    [SerializeField] private string gameOverScene;
    [SerializeField] Slider volumeSlider;

    public static event Action OnLanguageSet;
    public static int level;    
    
    private void OnEnable() => Player.OnGameOver += GameOver;
       
    private void OnDisable() => Player.OnGameOver -= GameOver;
    
    public void EngButt()
    {        
        UI.SetLang = "English";
        OnLanguageSet?.Invoke();
    }
    public void UaButt()
    {       
        UI.SetLang = "Ukrainian";
        OnLanguageSet?.Invoke();
    }
    public void OnVolumeChange() => UI.volLevel = volumeSlider.value;
    public void ChangeSceneButton(string sceneName) => SceneManager.LoadScene(sceneName);
    private void GameOver() => SceneManager.LoadScene(gameOverScene);

    public void QuitButt() => Application.Quit();
     
    public void ResetValues()
    {       
        Counter.counterValue = 0;
        level = 0;
    }
 
    

    
    
    
    

   

    



}


